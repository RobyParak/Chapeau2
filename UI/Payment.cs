using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Payment : Form
    {
        //Receive table and bill from orderForm
        Table table;
        Bill bill;
        Staff staff;
        SalesService salesService;

        public Payment(Table table, Bill bill, Staff staff)
        {
            InitializeComponent();
            this.bill = bill;
            this.table = table;
            this.staff = staff;
            salesService = new SalesService();

            //make method to show panel parsing it
            pnlFeedback.Hide();
            pnlPayment.Show();
            pnlCardPayment.Hide();
            pnlPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Hide();
            lblTableID.Text = table.Id.ToString();
            List<OrderItem> orderItems = salesService.GetOrdersForBill(table.Id);
            if (orderItems != null)
            {
                DisplayOrder(orderItems);
                DisplayVAT(orderItems);
                DisplayPrice(orderItems);
            }
            else
            {   //maybe add a message box about this
                GoToTableviewForm();
            }
        }
        private void DisplayOrder(List<OrderItem> orderItems)
        {
            
                listViewBill.Items.Clear();
                listViewBill.View = View.Details;
                foreach (OrderItem orderItem in orderItems)
                {
                    string[] items = { $"x{orderItem.Quantity}", orderItem.Item.ItemName, $"€{orderItem.Item.Price}" };
                    ListViewItem li = new ListViewItem(items);
                    listViewBill.Items.Add(li);
                }

           //this is for the cash panel because it must be different listview object
                listViewOrderCashPannel.Items.Clear();
                listViewOrderCashPannel.View = View.Details;
                foreach (OrderItem orderItem in orderItems)
                {
                    string[] items = { $"x{orderItem.Quantity}", orderItem.Item.ItemName, $"€{orderItem.Item.Price}" };
                    ListViewItem li = new ListViewItem(items);
                    listViewOrderCashPannel.Items.Add(li);
                }
            
        }
        private void CalculateAmountDue(List<OrderItem> orderItems)
        {
            foreach (OrderItem orderItem in orderItems)
                bill.AmountDue += orderItem.Item.Price;
        }
        private void DisplayPrice(List<OrderItem> orderItems)
        {
            CalculateAmountDue(orderItems);
            lblAmountDue.Text = "€ " + bill.AmountDue;
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //card payent opens a new panel where the payment is "being processed"
            pnlPayment.Hide();
            bill.PaymentMethod = PaymentType.Card;
            pnlCardPayment.Show();
            pnlCardPayment.Dock = DockStyle.Fill;
        }


        private void btnPaymentSuccessful_Click_1(object sender, EventArgs e)
        {
            PrintReceiptPopUp();
            pnlCardPayment.Hide();
            pnlFeedback.Show();
            pnlFeedback.Dock = DockStyle.Fill;
            
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            pnlCardPayment.Hide();
            pnlPayment.Show();
            pnlPayment.Dock = DockStyle.Fill;
        }

        private void PrintReceiptPopUp()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you wish to print a receipt", "Print Receipt", buttons);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Your receipt is being printed at the main till");
            }

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            bill.PaymentMethod = PaymentType.Cash;
            pnlPayment.Hide();
            pnlCashPayment.Show();
            pnlCashPayment.Dock = DockStyle.Fill;
           
        }

        private void UpdateOrderStatus()
        {
            //update the order status in the database
            foreach (Order order in bill.Orders)
            {
                order.IsPaid = true;
            }
            salesService.UpdateOrderStatus(bill);
        }



        private double CalculateVAT(int input, List<OrderItem> orderItems)
        {
            double vat = 0;
            foreach (OrderItem orderItem in orderItems)
            {
                if (orderItem.Item.VAT == input)
                    vat += (orderItem.Item.Price * orderItem.Item.VAT) / 100;
            }
            return vat;
        }
        private void DisplayVAT(List<OrderItem> orderItems)
        {
            double vat21 = CalculateVAT(21, orderItems);
            double vat6 = CalculateVAT(6, orderItems);
            lblVAT21.Text = $"€ {vat21:0.00}";
            lblVAT6.Text = $"€ {vat6:0.00}";
            bill.VAT = vat21 + vat6;
        }

        private void btnCalculateTipAndTotal_Click(object sender, EventArgs e)
        {
            if ((txtTip.Text != null) && (txtTip.Text != ""))
            {
                bill.Tip = double.Parse(txtTip.Text);
                bill.TotalDue = bill.AmountDue + bill.Tip;
                txtTotalDue.Text = bill.TotalDue.ToString();

            }
            else
            {
                
                    if (double.Parse(txtTotalDue.Text) > bill.AmountDue)
                    {
                        bill.TotalDue = double.Parse(txtTotalDue.Text);
                        bill.Tip = bill.TotalDue - bill.AmountDue;
                        txtTip.Text = bill.Tip.ToString();
                    }
                
                else
                    MessageBox.Show("Total due must be higher than amount due");

            }
            lblTotalDueCash.Text = "€ "+ bill.TotalDue.ToString();
        }

        private void btnEnterFeedback_Click(object sender, EventArgs e)
        {
          if (txtFeedback.Text != "")
                bill.Feedback = txtFeedback.Text;
            else
                bill.Feedback = "Feedback not provided";
            //then call a method to write bill to database
            salesService.UpdateBill(bill, table);
            //Update orders in database to paid
            UpdateOrderStatus();
            UpdateCurrentTable();
            GoToTableviewForm();
        }


        private void UpdateCurrentTable()
        {
            table.TableStatus = 0;
            table.BillId = 0;
        }
        private void GoToTableviewForm()
        {
            TableForm tableForm = new TableForm(table, staff);
            Close();
            tableForm.ShowDialog();
        }

        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<OrderItem> partialOrderForSplitting = new List<OrderItem>();
            
            try
            {
                if (listViewBill.SelectedItems.Count == 0)
                {
                    return;
                }
                else
                {
                    OrderItem itemToAdd = new OrderItem();
                    ListViewItem li = listViewBill.SelectedItems[0];
                    itemToAdd.Quantity = int.Parse(li.SubItems[0].Text);
                    itemToAdd.Item.ItemName = li.SubItems[1].Text;
                    itemToAdd.Item.Price = double.Parse(li.SubItems[2].Text);
                    partialOrderForSplitting.Add(itemToAdd);
                    bill.AmountDue += itemToAdd.Item.Price;
                    DisplayPrice(partialOrderForSplitting);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occoured: ", ex.Message);
            }
        }

        private void btnBackToOrderViewFromPaymentMainPage_Click(object sender, EventArgs e)
        {
            OrderView orderForm = new OrderView(table, bill, staff);
            Close();
            orderForm.ShowDialog();

        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtCashReceived.Text) > bill.TotalDue)
            {
                double ChangeDue = double.Parse(txtCashReceived.Text) - bill.TotalDue ;
                lblChange.Text = "€ " + ChangeDue.ToString();
            }
            else
                MessageBox.Show("To calculate change a greater ammount than total due must be entered");
        }

        private void btnPaymentConfirmedCash_Click(object sender, EventArgs e)
        {
            PrintReceiptPopUp();
            UpdateOrderStatus();
            //update table to available and set bill to Null
            UpdateCurrentTable();
            pnlCashPayment.Hide();
            pnlFeedback.Show();
            pnlFeedback.Dock = DockStyle.Fill;
        }

        private void btnGoToTableView_Click_1(object sender, EventArgs e)
        {
            //Update orders in database to paid
            UpdateOrderStatus();
            UpdateCurrentTable();
            GoToTableviewForm();
        }
    }
}



