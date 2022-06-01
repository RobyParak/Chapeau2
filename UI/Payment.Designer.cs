namespace UI
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.InactiveBorder, System.Drawing.SystemColors.WindowFrame, null);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.InactiveBorder, System.Drawing.SystemColors.WindowFrame, null);
            this.lblTableID = new System.Windows.Forms.Label();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculateTipAndTotal = new System.Windows.Forms.Button();
            this.lblVAT6 = new System.Windows.Forms.Label();
            this.lblVAT21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCard = new System.Windows.Forms.Button();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFeedback = new System.Windows.Forms.Panel();
            this.btnGoToTableView = new System.Windows.Forms.Button();
            this.btnEnterFeedback = new System.Windows.Forms.Button();
            this.btnBackTwo = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCardPayment = new System.Windows.Forms.Panel();
            this.btnPaymentSuccessful = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCashPayment = new System.Windows.Forms.Panel();
            this.listViewCashPayment = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.pnlPayment.SuspendLayout();
            this.pnlFeedback.SuspendLayout();
            this.pnlCardPayment.SuspendLayout();
            this.pnlCashPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTableID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTableID.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTableID.Location = new System.Drawing.Point(19, 20);
            this.lblTableID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(49, 27);
            this.lblTableID.TabIndex = 0;
            this.lblTableID.Text = "T_ID";
            // 
            // listViewBill
            // 
            this.listViewBill.AllowDrop = true;
            this.listViewBill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Quantity,
            this.Item,
            this.Price});
            this.listViewBill.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewBill.HideSelection = false;
            this.listViewBill.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewBill.Location = new System.Drawing.Point(19, 65);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(453, 444);
            this.listViewBill.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewBill.TabIndex = 1;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Q";
            this.Quantity.Width = 40;
            // 
            // Item
            // 
            this.Item.Text = "Name";
            this.Item.Width = 330;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 70;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.label10);
            this.pnlPayment.Controls.Add(this.label9);
            this.pnlPayment.Controls.Add(this.btnCalculateTipAndTotal);
            this.pnlPayment.Controls.Add(this.lblVAT6);
            this.pnlPayment.Controls.Add(this.lblVAT21);
            this.pnlPayment.Controls.Add(this.label8);
            this.pnlPayment.Controls.Add(this.label7);
            this.pnlPayment.Controls.Add(this.btnCash);
            this.pnlPayment.Controls.Add(this.label4);
            this.pnlPayment.Controls.Add(this.btnCard);
            this.pnlPayment.Controls.Add(this.txtTotalDue);
            this.pnlPayment.Controls.Add(this.txtTip);
            this.pnlPayment.Controls.Add(this.lblAmountDue);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Controls.Add(this.label2);
            this.pnlPayment.Controls.Add(this.label1);
            this.pnlPayment.Controls.Add(this.listViewBill);
            this.pnlPayment.Controls.Add(this.lblTableID);
            this.pnlPayment.Location = new System.Drawing.Point(16, 34);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(463, 643);
            this.pnlPayment.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 644);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 32);
            this.label10.TabIndex = 17;
            this.label10.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 596);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "€";
            // 
            // btnCalculateTipAndTotal
            // 
            this.btnCalculateTipAndTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculateTipAndTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateTipAndTotal.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCalculateTipAndTotal.Location = new System.Drawing.Point(338, 782);
            this.btnCalculateTipAndTotal.Name = "btnCalculateTipAndTotal";
            this.btnCalculateTipAndTotal.Size = new System.Drawing.Size(96, 38);
            this.btnCalculateTipAndTotal.TabIndex = 15;
            this.btnCalculateTipAndTotal.Text = "Calculate";
            this.btnCalculateTipAndTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTipAndTotal.Click += new System.EventHandler(this.btnCalculateTipAndTotal_Click);
            // 
            // lblVAT6
            // 
            this.lblVAT6.AutoSize = true;
            this.lblVAT6.Location = new System.Drawing.Point(338, 731);
            this.lblVAT6.Name = "lblVAT6";
            this.lblVAT6.Size = new System.Drawing.Size(27, 32);
            this.lblVAT6.TabIndex = 14;
            this.lblVAT6.Text = "€";
            // 
            // lblVAT21
            // 
            this.lblVAT21.AutoSize = true;
            this.lblVAT21.Location = new System.Drawing.Point(338, 694);
            this.lblVAT21.Name = "lblVAT21";
            this.lblVAT21.Size = new System.Drawing.Size(27, 32);
            this.lblVAT21.TabIndex = 13;
            this.lblVAT21.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 741);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "VAT at  6%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 694);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "VAT at 21%";
            // 
            // btnCash
            // 
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCash.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCash.Location = new System.Drawing.Point(265, 885);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(85, 38);
            this.btnCash.TabIndex = 10;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 832);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Select payment method";
            // 
            // btnCard
            // 
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCard.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCard.Location = new System.Drawing.Point(109, 885);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(85, 38);
            this.btnCard.TabIndex = 8;
            this.btnCard.Text = "Card";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Location = new System.Drawing.Point(365, 641);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.Size = new System.Drawing.Size(69, 39);
            this.txtTotalDue.TabIndex = 7;
            this.txtTotalDue.Tag = "";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(365, 589);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(69, 39);
            this.txtTip.TabIndex = 6;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(338, 552);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(27, 32);
            this.lblAmountDue.TabIndex = 5;
            this.lblAmountDue.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 648);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total due:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add tip:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount due:";
            // 
            // pnlFeedback
            // 
            this.pnlFeedback.Controls.Add(this.btnGoToTableView);
            this.pnlFeedback.Controls.Add(this.btnEnterFeedback);
            this.pnlFeedback.Controls.Add(this.btnBackTwo);
            this.pnlFeedback.Controls.Add(this.txtFeedback);
            this.pnlFeedback.Controls.Add(this.label6);
            this.pnlFeedback.Location = new System.Drawing.Point(61, 12);
            this.pnlFeedback.Name = "pnlFeedback";
            this.pnlFeedback.Size = new System.Drawing.Size(402, 431);
            this.pnlFeedback.TabIndex = 3;
            // 
            // btnGoToTableView
            // 
            this.btnGoToTableView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGoToTableView.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGoToTableView.Location = new System.Drawing.Point(212, 320);
            this.btnGoToTableView.Name = "btnGoToTableView";
            this.btnGoToTableView.Size = new System.Drawing.Size(115, 66);
            this.btnGoToTableView.TabIndex = 11;
            this.btnGoToTableView.Text = "back to table view";
            this.btnGoToTableView.UseVisualStyleBackColor = true;
            this.btnGoToTableView.Click += new System.EventHandler(this.btnGoToTableView_Click);
            // 
            // btnEnterFeedback
            // 
            this.btnEnterFeedback.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnterFeedback.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEnterFeedback.Location = new System.Drawing.Point(242, 250);
            this.btnEnterFeedback.Name = "btnEnterFeedback";
            this.btnEnterFeedback.Size = new System.Drawing.Size(85, 38);
            this.btnEnterFeedback.TabIndex = 10;
            this.btnEnterFeedback.Text = "Enter";
            this.btnEnterFeedback.UseVisualStyleBackColor = true;
            this.btnEnterFeedback.Click += new System.EventHandler(this.btnEnterFeedback_Click);
            // 
            // btnBackTwo
            // 
            this.btnBackTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackTwo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBackTwo.Location = new System.Drawing.Point(65, 334);
            this.btnBackTwo.Name = "btnBackTwo";
            this.btnBackTwo.Size = new System.Drawing.Size(85, 38);
            this.btnBackTwo.TabIndex = 9;
            this.btnBackTwo.Text = "Back";
            this.btnBackTwo.UseVisualStyleBackColor = true;
            // 
            // txtFeedback
            // 
            this.txtFeedback.AcceptsReturn = true;
            this.txtFeedback.AcceptsTab = true;
            this.txtFeedback.Location = new System.Drawing.Point(55, 125);
            this.txtFeedback.MaxLength = 5000;
            this.txtFeedback.MinimumSize = new System.Drawing.Size(4, 80);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeedback.Size = new System.Drawing.Size(271, 39);
            this.txtFeedback.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Let us know how we did";
            // 
            // pnlCardPayment
            // 
            this.pnlCardPayment.Controls.Add(this.btnPaymentSuccessful);
            this.pnlCardPayment.Controls.Add(this.btnBack);
            this.pnlCardPayment.Controls.Add(this.label5);
            this.pnlCardPayment.Location = new System.Drawing.Point(16, 866);
            this.pnlCardPayment.Name = "pnlCardPayment";
            this.pnlCardPayment.Size = new System.Drawing.Size(431, 157);
            this.pnlCardPayment.TabIndex = 4;
            // 
            // btnPaymentSuccessful
            // 
            this.btnPaymentSuccessful.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaymentSuccessful.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPaymentSuccessful.Location = new System.Drawing.Point(212, 733);
            this.btnPaymentSuccessful.Name = "btnPaymentSuccessful";
            this.btnPaymentSuccessful.Size = new System.Drawing.Size(170, 72);
            this.btnPaymentSuccessful.TabIndex = 10;
            this.btnPaymentSuccessful.Text = "Payment successful";
            this.btnPaymentSuccessful.UseVisualStyleBackColor = true;
            this.btnPaymentSuccessful.Click += new System.EventHandler(this.btnPaymentSuccessful_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.Location = new System.Drawing.Point(43, 733);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 72);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your payment is being processed";
            // 
            // pnlCashPayment
            // 
            this.pnlCashPayment.Controls.Add(this.listViewCashPayment);
            this.pnlCashPayment.Location = new System.Drawing.Point(16, 703);
            this.pnlCashPayment.Name = "pnlCashPayment";
            this.pnlCashPayment.Size = new System.Drawing.Size(447, 160);
            this.pnlCashPayment.TabIndex = 5;
            // 
            // listViewCashPayment
            // 
            this.listViewCashPayment.AllowDrop = true;
            this.listViewCashPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewCashPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCashPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewCashPayment.HideSelection = false;
            this.listViewCashPayment.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.listViewCashPayment.Location = new System.Drawing.Point(3, 39);
            this.listViewCashPayment.Name = "listViewCashPayment";
            this.listViewCashPayment.Size = new System.Drawing.Size(453, 408);
            this.listViewCashPayment.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewCashPayment.TabIndex = 2;
            this.listViewCashPayment.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Q";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 330;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 70;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(491, 1050);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCashPayment);
            this.Controls.Add(this.pnlCardPayment);
            this.Controls.Add(this.pnlFeedback);
            this.Controls.Add(this.pnlPayment);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Payment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Payment";
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            this.pnlCardPayment.ResumeLayout(false);
            this.pnlCardPayment.PerformLayout();
            this.pnlCashPayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Panel pnlFeedback;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Panel pnlCardPayment;
        private System.Windows.Forms.Button btnPaymentSuccessful;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGoToTableView;
        private System.Windows.Forms.Button btnEnterFeedback;
        private System.Windows.Forms.Button btnBackTwo;
        private System.Windows.Forms.Panel pnlCashPayment;
        private System.Windows.Forms.Label lblVAT6;
        private System.Windows.Forms.Label lblVAT21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateTipAndTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewCashPayment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}