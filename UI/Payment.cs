﻿using Logic;
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

        bool splitPayment = false;
        double subtotal = 0;
        public Payment(Table table, Bill bill, Staff staff)
        {
            InitializeComponent();
            this.bill = bill;
            this.table = table;
            this.staff = staff;
            salesService = new SalesService();
            tableService = new TableService();
            pnlFeedback.Hide();
            pnlPayment.Show();
            pnlCardPayment.Hide();
            pnlPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Hide();
            pnlSplitPayment.Hide();
            lblTableID.Text = table.Id.ToString();
            List<OrderItem> orderItems = GetListOfItems();
            CalculateAmountDue(orderItems);
            if (orderItems.Count > 0)
            {
                DisplayOrder(orderItems);
            }
            else
            {   //If no items to pay then go back to table view
                MessageBox.Show("Order contains no items");
                GoToTableviewForm();
            }
            DisplayOrderForCashPanel(orderItems);
        }
        private List<OrderItem> GetListOfItems()
        {
            return salesService.GetOrdersForBill(table.Id);
        }
        private void DisplayOrder(List<OrderItem> orderItems)
        {
            try
            {
                listViewBill.Items.Clear();
                listViewBill.View = View.Details;
                foreach (OrderItem orderItem in orderItems)
                {
                    string[] items = { $"x {orderItem.Quantity}", orderItem.Item.ItemName, $"{orderItem.Item.Price:###.00}" };
                    ListViewItem li = new ListViewItem(items);
                    this.listViewBill.Items.Add(li);
                }

                DisplayPrice();
                DisplayVAT(CalculateVAT(orderItems), TotalPriceIncludingVATButDivivedByVATPercentage(orderItems));

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
                listViewOrderCashPannel.Items.Clear();
                listViewOrderCashPannel.View = View.Details;
                foreach (OrderItem orderItem in orderItems)
                {
                    string[] items = { $"x {orderItem.Quantity}", orderItem.Item.ItemName, $"{orderItem.Item.Price:###0.00}" };
                    ListViewItem li = new ListViewItem(items);
                    listViewOrderCashPannel.Items.Add(li);
                }

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
            lblAmountDue.Text = $"€ {bill.AmountDue:#0.00}";
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
            //if the split payment option is "on" and not completed
            if ((splitPayment == true) & (subtotal != bill.TotalDue))
            {
                lblSplitTotalDue.Text = $"€ {(bill.TotalDue - subtotal):#0.00}";
                lblSplitRemainingToPay.Text = "€ ";

                pnlSplitPayment.Show();
                pnlCardPayment.Hide();
                pnlSplitPayment.Dock = DockStyle.Fill;
                ShowAmountPaid();
                txtEnteredAmountToPayForSplitting.Clear();

            }
            else
            {

                PrintReceiptPopUp();
                pnlCardPayment.Hide();
                pnlFeedback.Show();
                pnlFeedback.Dock = DockStyle.Fill;
            }
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
            DisplayTotalForCashPanel();
        }
        private void DisplayTotalForCashPanel()
        {
            lblTotalDueCash.Text = $"€ {bill.TotalDue:#0.00}";
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
        private double[] TotalPriceIncludingVATButDivivedByVATPercentage(List<OrderItem> orderItems)
        {

            double[] priceWithVAT = { 0, 0, };
            int vat6 = 6;
            foreach (OrderItem orderItem in orderItems)
            {
                if (orderItem.Item.VAT == vat6)
                    priceWithVAT[0] += orderItem.Item.Price;
                else
                    priceWithVAT[1] += orderItem.Item.Price;

            }
            return priceWithVAT;

        }
        private void DisplayVAT(double[] vat, double[] priceInclVAT)
        {
            lblVAT6.Text = $"€  {vat[0]: 0.00}";
            lblVAT21.Text = $"€  {vat[1]: 0.00}";
            if (priceInclVAT[0] != 0)
                lblPriceIncl6VAT.Text += $" of €{priceInclVAT[0]: 0.00}";
            if (priceInclVAT[1] != 0)
                lblPriceIncl21VAT.Text += $" of €{priceInclVAT[1]: 0.00}";
        }

        private void btnCalculateTipAndTotal_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTip.Text) && string.IsNullOrEmpty(txtTotalDue.Text))
                {
                    if ((double.Parse(txtTip.Text) < 0) || (double.Parse(txtTotalDue.Text) < 0))
                    { MessageBox.Show("This cannot be a negative number");
                }

                    bill.TotalDue = bill.AmountDue;
                    }
                
                else if (!string.IsNullOrEmpty(txtTip.Text))
                {
                    bill.Tip = double.Parse(txtTip.Text);
                    bill.TotalDue = bill.AmountDue + bill.Tip;
                    txtTotalDue.Text = $"{bill.TotalDue:#0.00}";

                }
                else
                {
                    if (double.Parse(txtTotalDue.Text) > bill.AmountDue)
                    {
                        bill.TotalDue = double.Parse(txtTotalDue.Text);
                        bill.Tip = bill.TotalDue - bill.AmountDue;
                        txtTip.Text = $"{bill.Tip:#0.00}";
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
            //if the payment has been split then update payment method here
            if (splitPayment == true)
                bill.PaymentMethod = PaymentType.Split_Payment;
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
            table.BillId = 0;
            tableService.ChangeTableToAvailable(table.Id);
        }
        private void GoToTableviewForm()
        {
            this.Hide();
            TableForm tableForm = new TableForm(staff);
            tableForm.ShowDialog();
            this.Close();
        }

        private void btnBackToOrderViewFromPaymentMainPage_Click(object sender, EventArgs e)
        {
            bill.AmountDue = 0;
            this.Hide();
            OrderView orderForm = new OrderView(table, bill, staff);
            Close();
            orderForm.ShowDialog();
        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            if ((double.Parse(txtCashReceived.Text) > bill.TotalDue) && (double.Parse(txtCashReceived.Text) > 0))
            {
                double ChangeDue = double.Parse(txtCashReceived.Text) - bill.TotalDue;
                lblChange.Text = $"€ {ChangeDue:#0.00}";
            }
            else
                MessageBox.Show("To calculate change a greater ammount than total due must be entered");
        }
        private void AddAmountToSubTotal()
        {
            subtotal += double.Parse(txtEnteredAmountToPayForSplitting.Text);
        }
        private void btnPaymentConfirmedCash_Click(object sender, EventArgs e)
        {
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
            splitPayment = true;
            pnlSplitPayment.Show();
            pnlPayment.Hide();
            pnlSplitPayment.Dock = DockStyle.Fill;
            lblSplitTotalDue.Text = $"€ {bill.TotalDue:00.00}";
        }

        private void btnBackFromSplit_Click(object sender, EventArgs e)
        {
            pnlSplitPayment.Hide();
            pnlPayment.Show();
            pnlPayment.Dock = DockStyle.Fill;
            splitPayment = false;
            subtotal = 0;
        }

        private void radBtnPin_CheckedChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtEnteredAmountToPayForSplitting.Text))
            {
                ShowRemainingToPayForSplitBill();
                ShowAmountPaid();
                if (radBtnPin.Checked)
                {
                    btnProcessCardSplitPayment.Enabled = true;
                    btnNextPayment.Enabled = false;
                    btnNextPayment.BackColor = DefaultBackColor;
                    btnProcessCardSplitPayment.BackColor = Color.LightBlue;
                }
            }
            else
            {
                MessageBox.Show("Please enter amount you wish to pay, first");
                radBtnPin.Checked = false;
            }
        }

        private void rdBtnCash_CheckedChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtEnteredAmountToPayForSplitting.Text))
            {
                ShowRemainingToPayForSplitBill();
                ShowAmountPaid();
                if (rdBtnCash.Checked)
                {
                    btnNextPayment.Enabled = true;
                    btnProcessCardSplitPayment.Enabled = false;
                    btnProcessCardSplitPayment.BackColor = DefaultBackColor;
                    btnNextPayment.BackColor = Color.LightBlue;
                }
            }
            else
            {
                MessageBox.Show("Please enter amount you wish to pay, first");
                rdBtnCash.Checked = false;
            }
        }

        private void btnProcessCardSplitPayment_Click(object sender, EventArgs e)
        {
            AddAmountToSubTotal();
            pnlSplitPayment.Hide();
            pnlCardPayment.Show();
            pnlCardPayment.Dock = DockStyle.Fill;
        }

        private void btnNextPayment_Click(object sender, EventArgs e)
        {
            //if remaining not 0 then repeat split payment
            AddAmountToSubTotal();
            lblSplitTotalDue.Text = $"€ {(bill.TotalDue - subtotal):#0.00}";

            rdBtnCash.Checked = false;
            btnNextPayment.Enabled = false;
            if (subtotal >= bill.TotalDue)
            {
                pnlSplitPayment.Hide();
                pnlFeedback.Show();
                pnlFeedback.Dock = DockStyle.Fill;
            }
            lblSplitRemainingToPay.Text = "€ ";
            ShowAmountPaid();
            txtEnteredAmountToPayForSplitting.Clear();
        }
        //do a method to remove paid from total and show a new total due
        private void ShowRemainingToPayForSplitBill()
        {
            lblSplitRemainingToPay.Text = $"€ {(bill.TotalDue - subtotal - double.Parse(txtEnteredAmountToPayForSplitting.Text)):00.00}";
        }
        private void ShowAmountPaid()
        {
            if (subtotal != 0)
                lblSubTotalPaid.Text = $"€ {subtotal:00.00}";
            else
                lblSubTotalPaid.Text = "€        0";
        }
    }
}