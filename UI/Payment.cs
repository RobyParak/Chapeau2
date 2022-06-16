using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        TableService tableService;
        List<OrderItem> orderItems;
        public Payment(Table table, Bill bill, Staff staff)
        {
            InitializeComponent();
            this.bill = bill;
            this.table = table;
            this.staff = staff;
            salesService = new SalesService();
            tableService = new TableService();
            //listViewItems = new List<ListViewItem>();
            pnlFeedback.Hide();
            pnlPayment.Show();
            pnlCardPayment.Hide();
            pnlPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Hide();
            lblTableID.Text = table.Id.ToString();
            //if reopening the form the total would add to the previous one each time
            //clearning the list prevents this issue
            if (orderItems != null)
            orderItems.Clear();
            orderItems = salesService.GetOrdersForBill(table.Id);
            
            if (orderItems.Count > 0)
            {
                DisplayOrder(orderItems);
            }
            else
            {   //If no items to pay then go back to table view
                MessageBox.Show("Order contains no items");
                GoToTableviewForm();
            }
        }
        private void DisplayOrder(List<OrderItem> orderItems)
        {
            try
            {
                listViewBill.Items.Clear();
                listViewBill.View = View.Details;
                foreach (OrderItem orderItem in orderItems)
                {
                    string[] items = { $"{orderItem.Quantity}", orderItem.Item.ItemName, $"{orderItem.Item.Price:00.00}" };
                    ListViewItem li = new ListViewItem(items);
                    this.listViewBill.Items.Add(li);
                }

                DisplayPrice();
                DisplayVAT(CalculateVAT(orderItems));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayOrderForCashPanel(List<OrderItem> orderItems)
        {
            try
            {
                //this is for the cash panel because it must be different listview object
                listViewOrderCashPannel.Items.Clear();
                listViewOrderCashPannel.View = View.Details;
                
                    foreach (OrderItem orderItem in orderItems)
                    {
                        string[] items = { $"x{orderItem.Quantity}", orderItem.Item.ItemName, $"€{orderItem.Item.Price}" };
                        ListViewItem li = new ListViewItem(items);
                        listViewOrderCashPannel.Items.Add(li);
                    }
                                CalculateAmountDue(orderItems);
                DisplayPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CalculateAmountDue(List<OrderItem> orderItems)
        {
            foreach (OrderItem orderItem in orderItems)
                bill.AmountDue += orderItem.Item.Price;
        }
        private void DisplayPrice()
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
            //this closes the card pnl and goes back to the main page
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
            DisplayStuffForCashPanel();
        }
        private void DisplayStuffForCashPanel()
        {
            DisplayOrderForCashPanel(orderItems);
            lblTotalDueCash.Text = "€ " + bill.TotalDue.ToString();
        }

        private void UpdateOrderStatusForWholeBill()
        {
            //update the order status in the database
            foreach (Order order in bill.Orders)
            {
                order.IsPaid = true;
            }
            salesService.UpdateOrderStatus(bill, table);
        }
       
        private double[] CalculateVAT(List<OrderItem> orderItems)
        {
            double[] vat = { 0, 0 };
            int vat6 = 6;
            foreach (OrderItem orderItem in orderItems)
            {
                if (orderItem.Item.VAT == vat6)
                    vat[0] += (orderItem.Item.Price * orderItem.Item.VAT) / 100;
                else
                    vat[1] += (orderItem.Item.Price * orderItem.Item.VAT) / 100;
            }
            bill.VAT = vat[0] + vat[1];
            return vat;
        }
        private void DisplayVAT(double[] vat)
        {
            lblVAT6.Text = $"€ {vat[0]:0.00}";
            lblVAT21.Text = $"€ {vat[1]:0.00}";
        }
        private void btnCalculateTipAndTotal_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTip.Text))
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occoured: ", ex.Message);
            }
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
            UpdateOrderStatusForWholeBill();
            UpdateCurrentTable();
            GoToTableviewForm();

        }


        private void UpdateCurrentTable()
        {
            table.TableStatus = 0;
            //table.BillId = 0;
            tableService.ChangeTableToAvailable(table.Id);
        }
        private void GoToTableviewForm()
        {
            Close();
            TableForm tableForm = new TableForm(table, staff);
            tableForm.ShowDialog();
        }

        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            //must delete the event
        }

        private void btnBackToOrderViewFromPaymentMainPage_Click(object sender, EventArgs e)
        {
          this.Hide();
            OrderView orderForm = new OrderView(table, bill, staff);
            orderForm.ShowDialog();
            Close();

        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtCashReceived.Text) > bill.TotalDue)
            {
                double ChangeDue = double.Parse(txtCashReceived.Text) - bill.TotalDue;
                lblChange.Text = "€ " + ChangeDue.ToString();
            }
            else
                MessageBox.Show("To calculate change a greater ammount than total due must be entered");
        }
        private void SplitBill()
        {
            //if not 
            bill.PaymentMethod = PaymentType.Splitted_Cash_and_Card;
         }
        private void UpdateFirstPanel()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occoured: ", ex.Message);
            }
        }
        private void btnPaymentConfirmedCash_Click(object sender, EventArgs e)
        {
            ////If the order has been split this makes sure it does not update all items yet
            //if (partialOrderForSplitting.Count != 0)
            //{
            //    SplitBill();
            //}
            //else
            //{
                PrintReceiptPopUp();
                pnlCashPayment.Hide();
                pnlFeedback.Show();
                pnlFeedback.Dock = DockStyle.Fill;
            
        }

        private void btnBackFromCashToMainPayment_Click(object sender, EventArgs e)
        {
            pnlCashPayment.Hide();
            pnlPayment.Show();
            pnlPayment.Dock = DockStyle.Fill;
        }

        private void btnSplitPayment_Click(object sender, EventArgs e)
        {
            pnlPayment.Hide();

            SplitBill();
        }
    }
}