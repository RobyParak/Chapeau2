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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.lblTableID = new System.Windows.Forms.Label();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBackToOrderViewFromPaymentMainPage = new System.Windows.Forms.Button();
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
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCardPayment = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPaymentSuccessful = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCashPayment = new System.Windows.Forms.Panel();
            this.btnPaymentConfirmedCash = new System.Windows.Forms.Button();
            this.listViewOrderCashPannel = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCalculateChange = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtCashReceived = new System.Windows.Forms.TextBox();
            this.lblTotalDueCash = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pnlPayment.SuspendLayout();
            this.pnlFeedback.SuspendLayout();
            this.pnlCardPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCashPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            resources.ApplyResources(this.lblTableID, "lblTableID");
            this.lblTableID.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTableID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTableID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTableID.Name = "lblTableID";
            // 
            // listViewBill
            // 
            resources.ApplyResources(this.listViewBill, "listViewBill");
            this.listViewBill.AllowDrop = true;
            this.listViewBill.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Quantity,
            this.Item,
            this.Price});
            this.listViewBill.FullRowSelect = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listViewBill.Items")))});
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.SelectedIndexChanged += new System.EventHandler(this.listViewBill_SelectedIndexChanged);
            // 
            // Quantity
            // 
            resources.ApplyResources(this.Quantity, "Quantity");
            // 
            // Item
            // 
            resources.ApplyResources(this.Item, "Item");
            // 
            // Price
            // 
            resources.ApplyResources(this.Price, "Price");
            // 
            // pnlPayment
            // 
            resources.ApplyResources(this.pnlPayment, "pnlPayment");
            this.pnlPayment.Controls.Add(this.label11);
            this.pnlPayment.Controls.Add(this.pnlCardPayment);
            this.pnlPayment.Controls.Add(this.btnBackToOrderViewFromPaymentMainPage);
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
            this.pnlPayment.Name = "pnlPayment";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // btnBackToOrderViewFromPaymentMainPage
            // 
            resources.ApplyResources(this.btnBackToOrderViewFromPaymentMainPage, "btnBackToOrderViewFromPaymentMainPage");
            this.btnBackToOrderViewFromPaymentMainPage.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBackToOrderViewFromPaymentMainPage.Name = "btnBackToOrderViewFromPaymentMainPage";
            this.btnBackToOrderViewFromPaymentMainPage.UseVisualStyleBackColor = true;
            this.btnBackToOrderViewFromPaymentMainPage.Click += new System.EventHandler(this.btnBackToOrderViewFromPaymentMainPage_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnCalculateTipAndTotal
            // 
            resources.ApplyResources(this.btnCalculateTipAndTotal, "btnCalculateTipAndTotal");
            this.btnCalculateTipAndTotal.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCalculateTipAndTotal.Name = "btnCalculateTipAndTotal";
            this.btnCalculateTipAndTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTipAndTotal.Click += new System.EventHandler(this.btnCalculateTipAndTotal_Click);
            // 
            // lblVAT6
            // 
            resources.ApplyResources(this.lblVAT6, "lblVAT6");
            this.lblVAT6.Name = "lblVAT6";
            // 
            // lblVAT21
            // 
            resources.ApplyResources(this.lblVAT21, "lblVAT21");
            this.lblVAT21.Name = "lblVAT21";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // btnCash
            // 
            resources.ApplyResources(this.btnCash, "btnCash");
            this.btnCash.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCash.Name = "btnCash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnCard
            // 
            resources.ApplyResources(this.btnCard, "btnCard");
            this.btnCard.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCard.Name = "btnCard";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // txtTotalDue
            // 
            resources.ApplyResources(this.txtTotalDue, "txtTotalDue");
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.Tag = "";
            // 
            // txtTip
            // 
            resources.ApplyResources(this.txtTip, "txtTip");
            this.txtTip.Name = "txtTip";
            // 
            // lblAmountDue
            // 
            resources.ApplyResources(this.lblAmountDue, "lblAmountDue");
            this.lblAmountDue.Name = "lblAmountDue";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pnlFeedback
            // 
            resources.ApplyResources(this.pnlFeedback, "pnlFeedback");
            this.pnlFeedback.Controls.Add(this.btnGoToTableView);
            this.pnlFeedback.Controls.Add(this.btnEnterFeedback);
            this.pnlFeedback.Controls.Add(this.txtFeedback);
            this.pnlFeedback.Controls.Add(this.label6);
            this.pnlFeedback.Name = "pnlFeedback";
            // 
            // btnGoToTableView
            // 
            resources.ApplyResources(this.btnGoToTableView, "btnGoToTableView");
            this.btnGoToTableView.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGoToTableView.Name = "btnGoToTableView";
            this.btnGoToTableView.UseVisualStyleBackColor = true;
            this.btnGoToTableView.Click += new System.EventHandler(this.btnGoToTableView_Click_1);
            // 
            // btnEnterFeedback
            // 
            resources.ApplyResources(this.btnEnterFeedback, "btnEnterFeedback");
            this.btnEnterFeedback.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEnterFeedback.Name = "btnEnterFeedback";
            this.btnEnterFeedback.UseVisualStyleBackColor = true;
            this.btnEnterFeedback.Click += new System.EventHandler(this.btnEnterFeedback_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.AcceptsReturn = true;
            this.txtFeedback.AcceptsTab = true;
            resources.ApplyResources(this.txtFeedback, "txtFeedback");
            this.txtFeedback.Name = "txtFeedback";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pnlCardPayment
            // 
            resources.ApplyResources(this.pnlCardPayment, "pnlCardPayment");
            this.pnlCardPayment.Controls.Add(this.pictureBox2);
            this.pnlCardPayment.Controls.Add(this.btnPaymentSuccessful);
            this.pnlCardPayment.Controls.Add(this.btnBack);
            this.pnlCardPayment.Controls.Add(this.label5);
            this.pnlCardPayment.Name = "pnlCardPayment";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // btnPaymentSuccessful
            // 
            resources.ApplyResources(this.btnPaymentSuccessful, "btnPaymentSuccessful");
            this.btnPaymentSuccessful.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPaymentSuccessful.Name = "btnPaymentSuccessful";
            this.btnPaymentSuccessful.UseVisualStyleBackColor = true;
            this.btnPaymentSuccessful.Click += new System.EventHandler(this.btnPaymentSuccessful_Click_1);
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pnlCashPayment
            // 
            resources.ApplyResources(this.pnlCashPayment, "pnlCashPayment");
            this.pnlCashPayment.Controls.Add(this.btnPaymentConfirmedCash);
            this.pnlCashPayment.Controls.Add(this.listViewOrderCashPannel);
            this.pnlCashPayment.Controls.Add(this.label14);
            this.pnlCashPayment.Controls.Add(this.btnCalculateChange);
            this.pnlCashPayment.Controls.Add(this.lblChange);
            this.pnlCashPayment.Controls.Add(this.txtCashReceived);
            this.pnlCashPayment.Controls.Add(this.lblTotalDueCash);
            this.pnlCashPayment.Controls.Add(this.label20);
            this.pnlCashPayment.Controls.Add(this.label21);
            this.pnlCashPayment.Controls.Add(this.label22);
            this.pnlCashPayment.Name = "pnlCashPayment";
            // 
            // btnPaymentConfirmedCash
            // 
            resources.ApplyResources(this.btnPaymentConfirmedCash, "btnPaymentConfirmedCash");
            this.btnPaymentConfirmedCash.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPaymentConfirmedCash.Name = "btnPaymentConfirmedCash";
            this.btnPaymentConfirmedCash.UseVisualStyleBackColor = true;
            this.btnPaymentConfirmedCash.Click += new System.EventHandler(this.btnPaymentConfirmedCash_Click);
            // 
            // listViewOrderCashPannel
            // 
            resources.ApplyResources(this.listViewOrderCashPannel, "listViewOrderCashPannel");
            this.listViewOrderCashPannel.AllowDrop = true;
            this.listViewOrderCashPannel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewOrderCashPannel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOrderCashPannel.FullRowSelect = true;
            this.listViewOrderCashPannel.HideSelection = false;
            this.listViewOrderCashPannel.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("listViewOrderCashPannel.Items")))});
            this.listViewOrderCashPannel.Name = "listViewOrderCashPannel";
            this.listViewOrderCashPannel.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewOrderCashPannel.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // btnCalculateChange
            // 
            resources.ApplyResources(this.btnCalculateChange, "btnCalculateChange");
            this.btnCalculateChange.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCalculateChange.Name = "btnCalculateChange";
            this.btnCalculateChange.UseVisualStyleBackColor = true;
            this.btnCalculateChange.Click += new System.EventHandler(this.btnCalculateChange_Click);
            // 
            // lblChange
            // 
            resources.ApplyResources(this.lblChange, "lblChange");
            this.lblChange.Name = "lblChange";
            // 
            // txtCashReceived
            // 
            resources.ApplyResources(this.txtCashReceived, "txtCashReceived");
            this.txtCashReceived.Name = "txtCashReceived";
            // 
            // lblTotalDueCash
            // 
            resources.ApplyResources(this.lblTotalDueCash, "lblTotalDueCash");
            this.lblTotalDueCash.Name = "lblTotalDueCash";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // Payment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pnlCashPayment);
            this.Controls.Add(this.pnlFeedback);
            this.Controls.Add(this.pnlPayment);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Payment";
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlFeedback.ResumeLayout(false);
            this.pnlFeedback.PerformLayout();
            this.pnlCardPayment.ResumeLayout(false);
            this.pnlCardPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCashPayment.ResumeLayout(false);
            this.pnlCashPayment.PerformLayout();
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
        private System.Windows.Forms.Panel pnlCashPayment;
        private System.Windows.Forms.Label lblVAT6;
        private System.Windows.Forms.Label lblVAT21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalculateTipAndTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBackToOrderViewFromPaymentMainPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCalculateChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtCashReceived;
        private System.Windows.Forms.Label lblTotalDueCash;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListView listViewOrderCashPannel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnPaymentConfirmedCash;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}