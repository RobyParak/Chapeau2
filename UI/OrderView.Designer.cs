
namespace UI
{
    partial class OrderView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTableNumber = new System.Windows.Forms.Label();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.Quantity = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonAddDrinks = new System.Windows.Forms.Button();
            this.groupBoxDrinks = new System.Windows.Forms.GroupBox();
            this.buttonWarm = new System.Windows.Forms.Button();
            this.buttonSpirits = new System.Windows.Forms.Button();
            this.buttonWine = new System.Windows.Forms.Button();
            this.buttonBeer = new System.Windows.Forms.Button();
            this.buttonSoft = new System.Windows.Forms.Button();
            this.groupBoxDinner = new System.Windows.Forms.GroupBox();
            this.buttonDessertsDinner = new System.Windows.Forms.Button();
            this.buttonMainsDinner = new System.Windows.Forms.Button();
            this.buttonEntDinner = new System.Windows.Forms.Button();
            this.buttonStartersDinner = new System.Windows.Forms.Button();
            this.groupBoxLunch = new System.Windows.Forms.GroupBox();
            this.buttonStartersLunch = new System.Windows.Forms.Button();
            this.buttonMainsLunch = new System.Windows.Forms.Button();
            this.buttonDessertsLunch = new System.Windows.Forms.Button();
            this.buttonAddDish = new System.Windows.Forms.Button();
            this.listViewMenu = new System.Windows.Forms.ListView();
            this.ItemId = new System.Windows.Forms.ColumnHeader();
            this.DishName = new System.Windows.Forms.ColumnHeader();
            this.DishPrice = new System.Windows.Forms.ColumnHeader();
            this.DishStock = new System.Windows.Forms.ColumnHeader();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDrinks = new System.Windows.Forms.Button();
            this.buttonDinner = new System.Windows.Forms.Button();
            this.buttonLunch = new System.Windows.Forms.Button();
            this.panelComment = new System.Windows.Forms.Panel();
            this.buttonCloseComment = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonReduceOne = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonComment = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.groupBoxDrinks.SuspendLayout();
            this.groupBoxDinner.SuspendLayout();
            this.groupBoxLunch.SuspendLayout();
            this.panelComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTableNumber
            // 
            this.labelTableNumber.AutoSize = true;
            this.labelTableNumber.Location = new System.Drawing.Point(14, 24);
            this.labelTableNumber.Name = "labelTableNumber";
            this.labelTableNumber.Size = new System.Drawing.Size(109, 20);
            this.labelTableNumber.TabIndex = 0;
            this.labelTableNumber.Text = "Table Number: ";
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ItemName,
            this.Quantity,
            this.Price,
            this.Comment});
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(14, 120);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(295, 699);
            this.listViewOrders.TabIndex = 1;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 30;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            // 
            // Quantity
            // 
            this.Quantity.Text = "";
            this.Quantity.Width = 30;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 150;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(333, 416);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(57, 67);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.textBoxQuantity);
            this.panelMenu.Controls.Add(this.labelQuantity);
            this.panelMenu.Controls.Add(this.buttonAddDrinks);
            this.panelMenu.Controls.Add(this.groupBoxDrinks);
            this.panelMenu.Controls.Add(this.groupBoxDinner);
            this.panelMenu.Controls.Add(this.groupBoxLunch);
            this.panelMenu.Controls.Add(this.buttonAddDish);
            this.panelMenu.Controls.Add(this.listViewMenu);
            this.panelMenu.Controls.Add(this.buttonClose);
            this.panelMenu.Controls.Add(this.buttonDrinks);
            this.panelMenu.Controls.Add(this.buttonDinner);
            this.panelMenu.Controls.Add(this.buttonLunch);
            this.panelMenu.Location = new System.Drawing.Point(31, 647);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(359, 473);
            this.panelMenu.TabIndex = 7;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(206, 412);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(27, 27);
            this.textBoxQuantity.TabIndex = 15;
            this.textBoxQuantity.Text = "1";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(141, 417);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(68, 20);
            this.labelQuantity.TabIndex = 14;
            this.labelQuantity.Text = "Quantity:";
            // 
            // buttonAddDrinks
            // 
            this.buttonAddDrinks.Location = new System.Drawing.Point(17, 408);
            this.buttonAddDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddDrinks.Name = "buttonAddDrinks";
            this.buttonAddDrinks.Size = new System.Drawing.Size(86, 31);
            this.buttonAddDrinks.TabIndex = 13;
            this.buttonAddDrinks.Text = "Add";
            this.buttonAddDrinks.UseVisualStyleBackColor = true;
            this.buttonAddDrinks.Click += new System.EventHandler(this.buttonAddDrinks_Click);
            // 
            // groupBoxDrinks
            // 
            this.groupBoxDrinks.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBoxDrinks.Controls.Add(this.buttonWarm);
            this.groupBoxDrinks.Controls.Add(this.buttonSpirits);
            this.groupBoxDrinks.Controls.Add(this.buttonWine);
            this.groupBoxDrinks.Controls.Add(this.buttonBeer);
            this.groupBoxDrinks.Controls.Add(this.buttonSoft);
            this.groupBoxDrinks.Location = new System.Drawing.Point(3, 160);
            this.groupBoxDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDrinks.Name = "groupBoxDrinks";
            this.groupBoxDrinks.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDrinks.Size = new System.Drawing.Size(359, 51);
            this.groupBoxDrinks.TabIndex = 11;
            this.groupBoxDrinks.TabStop = false;
            // 
            // buttonWarm
            // 
            this.buttonWarm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonWarm.Location = new System.Drawing.Point(265, 15);
            this.buttonWarm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonWarm.Name = "buttonWarm";
            this.buttonWarm.Size = new System.Drawing.Size(58, 31);
            this.buttonWarm.TabIndex = 8;
            this.buttonWarm.Text = "Warm";
            this.buttonWarm.UseVisualStyleBackColor = false;
            this.buttonWarm.Click += new System.EventHandler(this.buttonWarm_Click);
            // 
            // buttonSpirits
            // 
            this.buttonSpirits.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSpirits.Location = new System.Drawing.Point(202, 15);
            this.buttonSpirits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSpirits.Name = "buttonSpirits";
            this.buttonSpirits.Size = new System.Drawing.Size(58, 31);
            this.buttonSpirits.TabIndex = 7;
            this.buttonSpirits.Text = "Spirits";
            this.buttonSpirits.UseVisualStyleBackColor = false;
            this.buttonSpirits.Click += new System.EventHandler(this.buttonSpirits_Click);
            // 
            // buttonWine
            // 
            this.buttonWine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonWine.Location = new System.Drawing.Point(137, 15);
            this.buttonWine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonWine.Name = "buttonWine";
            this.buttonWine.Size = new System.Drawing.Size(58, 31);
            this.buttonWine.TabIndex = 6;
            this.buttonWine.Text = "Wine";
            this.buttonWine.UseVisualStyleBackColor = false;
            this.buttonWine.Click += new System.EventHandler(this.buttonWine_Click);
            // 
            // buttonBeer
            // 
            this.buttonBeer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBeer.Location = new System.Drawing.Point(72, 15);
            this.buttonBeer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBeer.Name = "buttonBeer";
            this.buttonBeer.Size = new System.Drawing.Size(58, 31);
            this.buttonBeer.TabIndex = 5;
            this.buttonBeer.Text = "Beer";
            this.buttonBeer.UseVisualStyleBackColor = false;
            this.buttonBeer.Click += new System.EventHandler(this.buttonBeer_Click);
            // 
            // buttonSoft
            // 
            this.buttonSoft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSoft.Location = new System.Drawing.Point(7, 15);
            this.buttonSoft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSoft.Name = "buttonSoft";
            this.buttonSoft.Size = new System.Drawing.Size(58, 31);
            this.buttonSoft.TabIndex = 4;
            this.buttonSoft.Text = "Soft";
            this.buttonSoft.UseVisualStyleBackColor = false;
            this.buttonSoft.Click += new System.EventHandler(this.buttonSoft_Click);
            // 
            // groupBoxDinner
            // 
            this.groupBoxDinner.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBoxDinner.Controls.Add(this.buttonDessertsDinner);
            this.groupBoxDinner.Controls.Add(this.buttonMainsDinner);
            this.groupBoxDinner.Controls.Add(this.buttonEntDinner);
            this.groupBoxDinner.Controls.Add(this.buttonStartersDinner);
            this.groupBoxDinner.Location = new System.Drawing.Point(3, 213);
            this.groupBoxDinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDinner.Name = "groupBoxDinner";
            this.groupBoxDinner.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxDinner.Size = new System.Drawing.Size(359, 51);
            this.groupBoxDinner.TabIndex = 10;
            this.groupBoxDinner.TabStop = false;
            // 
            // buttonDessertsDinner
            // 
            this.buttonDessertsDinner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDessertsDinner.Location = new System.Drawing.Point(265, 15);
            this.buttonDessertsDinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDessertsDinner.Name = "buttonDessertsDinner";
            this.buttonDessertsDinner.Size = new System.Drawing.Size(80, 31);
            this.buttonDessertsDinner.TabIndex = 7;
            this.buttonDessertsDinner.Text = "Desserts";
            this.buttonDessertsDinner.UseVisualStyleBackColor = false;
            this.buttonDessertsDinner.Click += new System.EventHandler(this.buttonDessertsDinner_Click);
            // 
            // buttonMainsDinner
            // 
            this.buttonMainsDinner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMainsDinner.Location = new System.Drawing.Point(181, 15);
            this.buttonMainsDinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainsDinner.Name = "buttonMainsDinner";
            this.buttonMainsDinner.Size = new System.Drawing.Size(80, 31);
            this.buttonMainsDinner.TabIndex = 6;
            this.buttonMainsDinner.Text = "Mains";
            this.buttonMainsDinner.UseVisualStyleBackColor = false;
            this.buttonMainsDinner.Click += new System.EventHandler(this.buttonMainsDinner_Click);
            // 
            // buttonEntDinner
            // 
            this.buttonEntDinner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEntDinner.Location = new System.Drawing.Point(94, 15);
            this.buttonEntDinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEntDinner.Name = "buttonEntDinner";
            this.buttonEntDinner.Size = new System.Drawing.Size(80, 31);
            this.buttonEntDinner.TabIndex = 5;
            this.buttonEntDinner.Text = "Entremets";
            this.buttonEntDinner.UseVisualStyleBackColor = false;
            this.buttonEntDinner.Click += new System.EventHandler(this.buttonEntDinner_Click);
            // 
            // buttonStartersDinner
            // 
            this.buttonStartersDinner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStartersDinner.Location = new System.Drawing.Point(7, 15);
            this.buttonStartersDinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStartersDinner.Name = "buttonStartersDinner";
            this.buttonStartersDinner.Size = new System.Drawing.Size(80, 31);
            this.buttonStartersDinner.TabIndex = 4;
            this.buttonStartersDinner.Text = "Starters";
            this.buttonStartersDinner.UseVisualStyleBackColor = false;
            this.buttonStartersDinner.Click += new System.EventHandler(this.buttonStartersDinner_Click);
            // 
            // groupBoxLunch
            // 
            this.groupBoxLunch.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBoxLunch.Controls.Add(this.buttonStartersLunch);
            this.groupBoxLunch.Controls.Add(this.buttonMainsLunch);
            this.groupBoxLunch.Controls.Add(this.buttonDessertsLunch);
            this.groupBoxLunch.Location = new System.Drawing.Point(10, 272);
            this.groupBoxLunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLunch.Name = "groupBoxLunch";
            this.groupBoxLunch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxLunch.Size = new System.Drawing.Size(359, 51);
            this.groupBoxLunch.TabIndex = 9;
            this.groupBoxLunch.TabStop = false;
            // 
            // buttonStartersLunch
            // 
            this.buttonStartersLunch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStartersLunch.Location = new System.Drawing.Point(7, 15);
            this.buttonStartersLunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStartersLunch.Name = "buttonStartersLunch";
            this.buttonStartersLunch.Size = new System.Drawing.Size(86, 31);
            this.buttonStartersLunch.TabIndex = 4;
            this.buttonStartersLunch.Text = "Starters";
            this.buttonStartersLunch.UseVisualStyleBackColor = false;
            this.buttonStartersLunch.Click += new System.EventHandler(this.buttonStarters_Click);
            // 
            // buttonMainsLunch
            // 
            this.buttonMainsLunch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMainsLunch.Location = new System.Drawing.Point(125, 15);
            this.buttonMainsLunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMainsLunch.Name = "buttonMainsLunch";
            this.buttonMainsLunch.Size = new System.Drawing.Size(86, 31);
            this.buttonMainsLunch.TabIndex = 5;
            this.buttonMainsLunch.Text = "Mains";
            this.buttonMainsLunch.UseVisualStyleBackColor = false;
            this.buttonMainsLunch.Click += new System.EventHandler(this.buttonMainsLunch_Click);
            // 
            // buttonDessertsLunch
            // 
            this.buttonDessertsLunch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDessertsLunch.Location = new System.Drawing.Point(248, 15);
            this.buttonDessertsLunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDessertsLunch.Name = "buttonDessertsLunch";
            this.buttonDessertsLunch.Size = new System.Drawing.Size(86, 31);
            this.buttonDessertsLunch.TabIndex = 6;
            this.buttonDessertsLunch.Text = "Desserts";
            this.buttonDessertsLunch.UseVisualStyleBackColor = false;
            this.buttonDessertsLunch.Click += new System.EventHandler(this.buttonDessertsLunch_Click);
            // 
            // buttonAddDish
            // 
            this.buttonAddDish.Location = new System.Drawing.Point(263, 412);
            this.buttonAddDish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddDish.Name = "buttonAddDish";
            this.buttonAddDish.Size = new System.Drawing.Size(86, 31);
            this.buttonAddDish.TabIndex = 8;
            this.buttonAddDish.Text = "Add";
            this.buttonAddDish.UseVisualStyleBackColor = true;
            this.buttonAddDish.Click += new System.EventHandler(this.buttonAddLunch_Click);
            // 
            // listViewMenu
            // 
            this.listViewMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemId,
            this.DishName,
            this.DishPrice,
            this.DishStock});
            this.listViewMenu.FullRowSelect = true;
            this.listViewMenu.HideSelection = false;
            this.listViewMenu.Location = new System.Drawing.Point(15, 160);
            this.listViewMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewMenu.Name = "listViewMenu";
            this.listViewMenu.Size = new System.Drawing.Size(333, 228);
            this.listViewMenu.TabIndex = 7;
            this.listViewMenu.UseCompatibleStateImageBehavior = false;
            this.listViewMenu.View = System.Windows.Forms.View.Details;
            // 
            // ItemId
            // 
            this.ItemId.Width = 0;
            // 
            // DishName
            // 
            this.DishName.Text = "Name";
            // 
            // DishPrice
            // 
            this.DishPrice.Text = "Price";
            // 
            // DishStock
            // 
            this.DishStock.Text = "Stock";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(321, 4);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(34, 36);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDrinks
            // 
            this.buttonDrinks.Location = new System.Drawing.Point(263, 48);
            this.buttonDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDrinks.Name = "buttonDrinks";
            this.buttonDrinks.Size = new System.Drawing.Size(86, 31);
            this.buttonDrinks.TabIndex = 2;
            this.buttonDrinks.Text = "Drinks";
            this.buttonDrinks.UseVisualStyleBackColor = true;
            this.buttonDrinks.Click += new System.EventHandler(this.buttonDrinks_Click);
            // 
            // buttonDinner
            // 
            this.buttonDinner.Location = new System.Drawing.Point(139, 48);
            this.buttonDinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDinner.Name = "buttonDinner";
            this.buttonDinner.Size = new System.Drawing.Size(86, 31);
            this.buttonDinner.TabIndex = 1;
            this.buttonDinner.Text = "Dinner";
            this.buttonDinner.UseVisualStyleBackColor = true;
            this.buttonDinner.Click += new System.EventHandler(this.buttonDinner_Click);
            // 
            // buttonLunch
            // 
            this.buttonLunch.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLunch.Location = new System.Drawing.Point(15, 48);
            this.buttonLunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLunch.Name = "buttonLunch";
            this.buttonLunch.Size = new System.Drawing.Size(86, 31);
            this.buttonLunch.TabIndex = 0;
            this.buttonLunch.Text = "Lunch";
            this.buttonLunch.UseVisualStyleBackColor = false;
            this.buttonLunch.Click += new System.EventHandler(this.buttonLunch_Click);
            // 
            // panelComment
            // 
            this.panelComment.Controls.Add(this.buttonCloseComment);
            this.panelComment.Controls.Add(this.buttonDone);
            this.panelComment.Controls.Add(this.labelComment);
            this.panelComment.Controls.Add(this.textBoxComment);
            this.panelComment.Location = new System.Drawing.Point(51, 299);
            this.panelComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(338, 140);
            this.panelComment.TabIndex = 7;
            // 
            // buttonCloseComment
            // 
            this.buttonCloseComment.Location = new System.Drawing.Point(293, 8);
            this.buttonCloseComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseComment.Name = "buttonCloseComment";
            this.buttonCloseComment.Size = new System.Drawing.Size(34, 36);
            this.buttonCloseComment.TabIndex = 4;
            this.buttonCloseComment.Text = "X";
            this.buttonCloseComment.UseVisualStyleBackColor = true;
            this.buttonCloseComment.Click += new System.EventHandler(this.buttonCloseComment_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(238, 91);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(86, 31);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Finalize";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(30, 56);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(77, 20);
            this.labelComment.TabIndex = 1;
            this.labelComment.Text = "Comment:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(110, 52);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(213, 27);
            this.textBoxComment.TabIndex = 0;
            // 
            // buttonReduceOne
            // 
            this.buttonReduceOne.Location = new System.Drawing.Point(335, 120);
            this.buttonReduceOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReduceOne.Name = "buttonReduceOne";
            this.buttonReduceOne.Size = new System.Drawing.Size(57, 67);
            this.buttonReduceOne.TabIndex = 4;
            this.buttonReduceOne.Text = "-1";
            this.buttonReduceOne.UseVisualStyleBackColor = true;
            this.buttonReduceOne.Click += new System.EventHandler(this.buttonReduceOne_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(335, 208);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(57, 67);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "-all";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(335, 299);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(57, 67);
            this.buttonComment.TabIndex = 2;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // buttonBill
            // 
            this.buttonBill.Location = new System.Drawing.Point(333, 493);
            this.buttonBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(57, 67);
            this.buttonBill.TabIndex = 2;
            this.buttonBill.Text = "Bill";
            this.buttonBill.UseVisualStyleBackColor = true;
            this.buttonBill.Click += new System.EventHandler(this.buttonBill_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(283, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 36);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(155, 23);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(97, 20);
            this.lblLogout.TabIndex = 12;
            this.lblLogout.Text = "Logged in as:";
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(14, 67);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 45);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "←";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(393, 840);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.buttonBill);
            this.Controls.Add(this.panelComment);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonReduceOne);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.labelTableNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.groupBoxDrinks.ResumeLayout(false);
            this.groupBoxDinner.ResumeLayout(false);
            this.groupBoxLunch.ResumeLayout(false);
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTableNumber;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonDrinks;
        private System.Windows.Forms.Button buttonDinner;
        private System.Windows.Forms.Button buttonLunch;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListView listViewMenu;
        private System.Windows.Forms.Button buttonDessertsLunch;
        private System.Windows.Forms.Button buttonMainsLunch;
        private System.Windows.Forms.Button buttonStartersLunch;
        private System.Windows.Forms.ColumnHeader ItemId;
        private System.Windows.Forms.ColumnHeader DishName;
        private System.Windows.Forms.ColumnHeader DishPrice;
        private System.Windows.Forms.ColumnHeader DishStock;
        private System.Windows.Forms.Button buttonAddDish;
        private System.Windows.Forms.GroupBox groupBoxLunch;
        private System.Windows.Forms.GroupBox groupBoxDinner;
        private System.Windows.Forms.Button buttonDessertsDinner;
        private System.Windows.Forms.Button buttonMainsDinner;
        private System.Windows.Forms.Button buttonEntDinner;
        private System.Windows.Forms.Button buttonStartersDinner;
        private System.Windows.Forms.GroupBox groupBoxDrinks;
        private System.Windows.Forms.Button buttonWarm;
        private System.Windows.Forms.Button buttonSpirits;
        private System.Windows.Forms.Button buttonWine;
        private System.Windows.Forms.Button buttonBeer;
        private System.Windows.Forms.Button buttonSoft;
        private System.Windows.Forms.Button buttonAddDrinks;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button buttonReduceOne;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonCloseComment;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button buttonBack;
    }
}

