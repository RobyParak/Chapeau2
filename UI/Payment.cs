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
        SalesService salesService;

        //Asked Gerwin how else could this be done without global
        //cannot be done, this global stays
        List<OrderItem> ordersItems;
        public Payment(Table table, Bill bill)
        {
            InitializeComponent();
            this.bill = bill;
            salesService = new SalesService();
            this.table = table;
            //make method to show panel parsing it
            pnlFeedback.Hide();
            pnlPayment.Show();
            pnlCardPayment.Hide();
            pnlPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Hide();
            lblTableID.Text = table.Id.ToString();
            ordersItems = salesService.GetOrdersForBill(table.Id);
            DisplayOrder(ordersItems);
        }
        private void DisplayOrder(List<OrderItem> orderItems)
        {
            listViewBill.Items.Clear();
            listViewBill.View = View.Details;
            foreach (OrderItem orderItem in orderItems)
            {
                string[] items = {$"x{orderItem.Quantity}", orderItem.Item.ItemName, $"€{orderItem.Item.Price}"};
                ListViewItem li = new ListViewItem(items);
                listViewBill.Items.Add(li);
            }
            DisplayPrice(orderItems);
        }
        private void DisplayPrice(List<OrderItem> orderItems)
        {
            //get bill
          
            foreach (OrderItem orderItem in orderItems)
                bill.AmountDue += orderItem.Item.Price;

        lblAmountDue.Text= "€" + bill.AmountDue;

        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //card payent opens a new panel where the payment is "being processed"
            bill.PaymentMethod = PaymentType.Card;
            pnlCardPayment.Show();
            pnlPayment.Hide();
            pnlCardPayment.Dock = DockStyle.Fill;
        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            bill.Tip = double.Parse(txtTip.Text);
            bill.TotalDue = bill.AmountDue + bill.Tip;
            txtTotalDue.Text = bill.TotalDue.ToString();
        }

        private void txtTotalDue_TextChanged(object sender, EventArgs e)
        {
            if (txtTip.Text != "")
                bill.TotalDue = bill.AmountDue + bill.Tip;
            else
                bill.TotalDue = double.Parse(txtTotalDue.Text);
        }
        
        private void btnPaymentSuccessful_Click_1(object sender, EventArgs e)
        {
            pnlCardPayment.Hide();
            pnlFeedback.Show();
            pnlFeedback.Dock = DockStyle.Fill;
            //Update orders in database to paid
           UpdateOrderStatus();
            //Set billID to null in table and update that
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            pnlCardPayment.Hide();
            pnlPayment.Show();
            pnlPayment.Dock = DockStyle.Fill;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            //change name
            bill.Feedback = txtFeedback.Text;
            //then call a method to write bill to database
            salesService.UpdateBill(bill);

            //change table status to available
            table.TableStatus = 0;
           //set tableID to null

            //have a print receipt pop up
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            bill.PaymentMethod = PaymentType.Cash;
            //TO DO another panel that helps the waiter with the change

            //move this to other panel
            UpdateOrderStatus();
            //update table to available and set bill to Null
        }

        private void UpdateOrderStatus()
        {
            //update the order status in the database
            foreach (Order order in bill.Orders)
            {
                order.IsPaid = true;
                salesService.UpdateOrderStatus(order);
            }
        }
    }
}

