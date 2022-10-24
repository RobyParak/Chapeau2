using Logic;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class Payment : Form
    {
        //Receive table
        Table table;
        Bill bill;

        //left the staff to open the tableview after but it's null atm
        Staff staff;
        SalesService salesService;
        TableService tableService;
        BillService billService;
       
        bool splitPayment = false;

        //global - yes I need it in a button 
        double subtotal = 0;
        public Payment(Table table)
        {
            InitializeComponent();
            salesService = new SalesService();
            tableService = new TableService();
            billService = new BillService();

            this.table = table;
            //given the tableID get the billId from the database
            Bill bill = new Bill(billService.GetBillIdByTableId(table.Id));
            this.bill = bill;
            
            //had to initiate the objects here since the order part is not implemented
            bill.Order = new Order();
            bill.Order.OrderItems = new List<OrderItem>();
          
            pnlFeedback.Hide();
            pnlPayment.Show();
            pnlCardPayment.Hide();
            pnlPayment.Dock = DockStyle.Fill;
            pnlCashPayment.Hide();
            pnlSplitPayment.Hide();
            lblTableID.Text = table.Id.ToString();
            GetListOfItems();
        }
        private void GetListOfItems()
        {
            //added this so if the form is reloaded the items won't be entered in the list twice
            if (bill.Order.OrderItems.Count != 0)
            { bill.Order.OrderItems.Clear(); } 
            else
            {   bill.Order.OrderItems = salesService.GetOrdersForBill(table.Id); }
            if (bill.Order.OrderItems.Count > 0)
            {
                DisplayOrder(bill.Order.OrderItems);
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
                    string[] items = { $"{orderItem.Quantity}", orderItem.Item.ItemName, $"{orderItem.Item.Price:###.00}" };
                    ListViewItem li = new ListViewItem(items);
                    this.listViewBill.Items.Add(li);
                }

                DisplayPrice();
                int vatValue6 = 6;
                int vatValue21 = 21;
                bill.VAT = (CalculateVAT(orderItems, vatValue6) + CalculateVAT(orderItems, vatValue21));
                DisplayVAT(CalculateVAT(orderItems, vatValue6), CalculateVAT(orderItems, vatValue21), TotalPriceIncludingVATButDivivedByVATPercentage(vatValue6), TotalPriceIncludingVATButDivivedByVATPercentage(vatValue21));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayOrderForCashPanel()
        {
            try
            {
                listViewOrderCashPannel.Items.Clear();
                listViewOrderCashPannel.View = View.Details;
                foreach (OrderItem orderItem in bill.Order.OrderItems)
                {
                    string[] items = { $"{orderItem.Quantity}", orderItem.Item.ItemName, $"{orderItem.Item.Price:#0.00}" };
                    ListViewItem li = new ListViewItem(items);
                    listViewOrderCashPannel.Items.Add(li);
                }

                CalculateAmountDue(bill.Order.OrderItems);
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
            CalculateAmountDue(bill.Order.OrderItems);
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
            //Here is when I do the loop and I need the subtotal var for it
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
            DisplayStuffForCashPanel();
        }
        private void DisplayStuffForCashPanel()
        {
            DisplayOrderForCashPanel();
            lblTotalDueCash.Text = $"€ {bill.TotalDue:#0.00}";
        }

        private void UpdateOrderStatusForWholeBill()
        {
            //update the order status in the database
            foreach (Order order in bill.Orders)
            {
                order.PaidStatus = PaidStatus.IsPaid;
            }
            salesService.UpdateOrderStatus(bill, table);
        }

        private double CalculateVAT(List<OrderItem> orderItems, int vatValue)
        {
            double vat = 0;
            foreach (OrderItem orderItem in orderItems)
            {
                if (orderItem.Item.VAT == vatValue)
                   vat += (orderItem.Item.Price * orderItem.Item.VAT) / 100;
            }
            return vat;
        }
        private double TotalPriceIncludingVATButDivivedByVATPercentage(int vatValue)
        {

            double priceWithVAT = 0;
            foreach (OrderItem orderItem in bill.Order.OrderItems)
            {
                if (orderItem.Item.VAT == vatValue)
                    priceWithVAT += orderItem.Item.Price;
            }
            return priceWithVAT;

        }
        private void DisplayVAT(double lowVat, double highVat, double lowPriceInclVAT, double highPriceInclVat)
        {
            lblVAT6.Text = $"€ {lowVat:00.00}";
            lblVAT21.Text = $"€ {highVat:00.00}";
            lblPriceIncl6VAT.Text += $" of €{lowPriceInclVAT:00.00}";
            lblPriceIncl21VAT.Text += $" of €{highPriceInclVat:00.00}";
        }

        private void btnCalculateTipAndTotal_Click(object sender, EventArgs e)
        {
            try
            {
                //minus number for both total and tips
                if (string.IsNullOrEmpty(txtTip.Text) && string.IsNullOrEmpty(txtTotalDue.Text) && (double.Parse(txtTip.Text) > 0))
                    bill.TotalDue = bill.AmountDue;
                else if (!string.IsNullOrEmpty(txtTip.Text) && (double.Parse(txtTip.Text) > 0))
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
            tableService.ChangeTableToAvailable(table.Id);
        }
        private void GoToTableviewForm()
        {
            TableForm tableForm = new TableForm(staff);
            this.Close();
            tableForm.ShowDialog();
        }

        private void btnBackToOrderViewFromPaymentMainPage_Click(object sender, EventArgs e)
        {
            Close();
            OrderView orderForm = new OrderView(table, bill, staff);
            orderForm.ShowDialog();

        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtCashReceived.Text) > bill.TotalDue)
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

            if (!string.IsNullOrEmpty(txtEnteredAmountToPayForSplitting.Text) && (double.Parse(txtEnteredAmountToPayForSplitting.Text) > 0))
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
                MessageBox.Show("Entered amount must be a positive number");
                radBtnPin.Checked = false;
            }
        }

        private void rdBtnCash_CheckedChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtEnteredAmountToPayForSplitting.Text) && (double.Parse(txtEnteredAmountToPayForSplitting.Text) > 0))
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
                MessageBox.Show("Entered amount must be a positive number");
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
        //the below is to remove paid from total and show a new total due
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