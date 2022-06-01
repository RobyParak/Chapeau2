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
        //need to get the table ID
        Table table;
        Bill bill;
        SalesService salesService;

        //Ask Gerwin how else could this be done without global
        List<OrderItem> orderItems;
        public Payment(Table table, int billId)
        {
            InitializeComponent();

            salesService = new SalesService();
            this.table = table;
            bill = new Bill
            {
                BillId = billId
            };

            //make method to show panel parsing it
            pnlFeedback.Hide();
            pnlPayment.Show();
            pnlCardPayment.Hide();
            pnlPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Hide();
            lblTableID.Text = table.Id.ToString();
            orderItems = salesService.GetOrdersForBill(table.Id);
            DisplayOrder(orderItems);
            DisplayVAT();
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
            DisplayPrice(orderItems);
        }
        private void DisplayPrice(List<OrderItem> orderItems)
        {

            foreach (OrderItem orderItem in orderItems)
                bill.AmountDue += orderItem.Item.Price;

            lblAmountDue.Text = "€ " + bill.AmountDue;
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //card payent opens a new panel where the payment is "being processed"

            //enum
            bill.PaymentMethod = PaymentType.Card;
            pnlCardPayment.Show();
            pnlPayment.Hide();
            pnlCardPayment.Dock = DockStyle.Fill;
        }


        private void btnPaymentSuccessful_Click_1(object sender, EventArgs e)
        {
            PrintReceiptPopUp();
            pnlCardPayment.Hide();
            pnlFeedback.Show();
            pnlFeedback.Dock = DockStyle.Fill;
            //Update orders in database to paid
            //UpdateOrderStatus();
       
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
            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Your receipt is being printed at the main till");
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            bill.PaymentMethod = PaymentType.Cash;
            //TO DO another panel that helps the waiter with the change

            //To do: When successful call updateOrderStatus Method
            PrintReceiptPopUp();
        }

        //private void UpdateOrderStatus()
        //{
        //    //update the order status get it from Dimitar or do a new query?
        //    foreach (Order order in orders)
        //    {
        //        order.IsPaid = true;
        //        salesService.UpdateOrderStatus(order);
        //    }
        //}
        private double CalculateVAT(int input)
        {
            double vat = 0;
            foreach (OrderItem orderItem in orderItems)
            {
                if (orderItem.Item.VAT == input)
                    vat += (orderItem.Item.Price * orderItem.Item.VAT) / 100;
            }
            return vat;
        }
        private void DisplayVAT()
        {
            double vat21 = CalculateVAT(21);
            double vat6 = CalculateVAT(6);
            lblVAT21.Text = "€ " + vat21;
            lblVAT6.Text = "€ " + vat6;
        }

        private void btnCalculateTipAndTotal_Click(object sender, EventArgs e)
        {
            if (txtTip.Text == null)
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

        private void btnEnterFeedback_Click(object sender, EventArgs e)
        {
            if (txtFeedback.Text != "")
                bill.Feedback = txtFeedback.Text;
            else
                bill.Feedback = "Feedback not provided";
            //then call a method to write bill to database
            salesService.UpdateBill(bill);

            //change table status to available
            table.TableStatus = 0;
            //TO DO update status on form or on database?
        }

        private void btnGoToTableView_Click(object sender, EventArgs e)
        {
            //close this form and open the table view one
           
        }
    }
}