using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Login;
using Model;
using Service;

namespace UI
{
    public partial class OrderView : Form
    {
        Table _table;
        Bill _bill;
        Staff _staff;
        OrderService _orderService;
        DishService _dishService;
        DrinkService _drinkService;

        public OrderView(Table table, Bill bill, Staff staff)
        {
            InitializeComponent();
            InitMenu();
            btnLogout.Text = "Logout";
            lblLogout.Text = "Logged in as: " + staff.FirstName;
            _table = table;
            _bill = bill;
            _staff = staff;
            labelTableNumber.Text += table.Id;
            _orderService = new OrderService();
            List<Order> orders = _orderService.GetAllOrdersForTable(_table.Id);
            _dishService = new DishService();
            _drinkService = new DrinkService();
            DisplayOrders(orders);
        }

        private void InitMenu()
        {
            panelComment.Visible = false;
            panelMenu.Visible = false;
            groupBoxLunch.Location = new Point(0, 65);
            groupBoxDinner.Location = new Point(0, 65);
            groupBoxDrinks.Location = new Point(0, 65);
            groupBoxLunch.Visible = false;
            groupBoxDinner.Visible = false;
            buttonAddDish.Location = new Point(230, 309);
            buttonAddDrinks.Location = new Point(230, 309);
        }

        private void DisplayOrders(List<Order> orders)
        {
            listViewOrders.Items.Clear();
            foreach(Order order in orders)
            {

                string[] items = { order.OrderId.ToString(), order.ItemName,$"x{order.Quantity}", $"{order.Price * order.Quantity}", order.Comment };
                ListViewItem li = new ListViewItem(items);
                listViewOrders.Items.Add(li);
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelMenu.Location = new Point(27, 290);
            panelMenu.TabIndex = 8;
            buttonBill.TabIndex = 0;
            buttonAddDish.Visible = true;
            buttonAddDrinks.Visible = false;
            listViewMenu.Items.Clear();
            buttonStartersLunch.ForeColor = Color.Blue;
            buttonMainsLunch.ForeColor = Color.Black;
            buttonDessertsLunch.ForeColor = Color.Black;
            buttonLunch.BackColor = Color.DodgerBlue;
            buttonDinner.BackColor = Color.White;
            buttonDrinks.BackColor = Color.White;
            groupBoxLunch.Visible = true;
            groupBoxDinner.Visible = false;
            List<Dish> lunchMenu = _dishService.GetLunchDishes();
            List<Dish> starters = lunchMenu.Where(a => a.DishType == 0).ToList();
            foreach (Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            buttonStartersLunch.ForeColor = Color.Black;
            buttonMainsLunch.ForeColor = Color.Black;
            buttonDessertsLunch.ForeColor = Color.Black;
        }

        private void buttonStarters_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonStartersLunch.ForeColor = Color.Blue;
            buttonMainsLunch.ForeColor = Color.Black;
            buttonDessertsLunch.ForeColor = Color.Black;
            List<Dish> lunchMenu = _dishService.GetLunchDishes();
            List<Dish> starters = lunchMenu.Where(a => a.DishType == 0).ToList();
            foreach(Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString()};
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonMainsLunch_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonMainsLunch.ForeColor = Color.Blue;
            buttonStartersLunch.ForeColor = Color.Black;
            buttonDessertsLunch.ForeColor = Color.Black;
            List<Dish> lunchMenu = _dishService.GetLunchDishes();
            List<Dish> mains = lunchMenu.Where(a => a.DishType == 1).ToList();
            foreach (Dish dish in mains)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonDessertsLunch_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonDessertsLunch.ForeColor = Color.Blue;
            buttonMainsLunch.ForeColor = Color.Black;
            buttonStartersLunch.ForeColor = Color.Black;
            List<Dish> lunchMenu = _dishService.GetLunchDishes();
            List<Dish> desserts = lunchMenu.Where(a => a.DishType == 2).ToList();
            foreach (Dish dish in desserts)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonAddLunch_Click(object sender, EventArgs e)
        {
            if(listViewMenu.SelectedItems.Count==0)
            {
                MessageBox.Show("Select a Dish!");
                return;
            }
            var selectedRow = listViewMenu.SelectedItems[0];
            Dish dish = _dishService.GetDishById(int.Parse(selectedRow.SubItems[0].Text));
            Order order = new Order()
            {
                BillId = _bill.BillId,
                TableId = _table.Id,
                Quantity = int.Parse(textBoxQuantity.Text)
            };
            _bill.Orders.Add(order);
            _orderService.CreateOrder(order, dish);
            List<Order> orders = _orderService.GetAllOrdersForTable(_table.Id);
            DisplayOrders(orders);
        }

        private void buttonLunch_Click(object sender, EventArgs e)
        {
            buttonAddDish.Visible = true;
            buttonAddDrinks.Visible = false;
            buttonLunch.BackColor = Color.DodgerBlue;
            buttonDinner.BackColor = Color.White;
            buttonDrinks.BackColor = Color.White;
            groupBoxLunch.Visible = true;
            groupBoxDinner.Visible = false;
            groupBoxDrinks.Visible = false;
            listViewMenu.Items.Clear();
            buttonStartersLunch.ForeColor = Color.Blue;
            buttonMainsLunch.ForeColor = Color.Black;
            buttonDessertsLunch.ForeColor = Color.Black;
            List<Dish> lunchMenu = _dishService.GetLunchDishes();
            List<Dish> starters = lunchMenu.Where(a => a.DishType == 0).ToList();
            foreach (Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonDinner_Click(object sender, EventArgs e)
        {
            buttonAddDish.Visible = true;
            buttonAddDrinks.Visible = false;
            buttonLunch.BackColor = Color.White;
            buttonDinner.BackColor = Color.DodgerBlue;
            buttonDrinks.BackColor = Color.White;
            groupBoxDinner.Visible = true;
            groupBoxLunch.Visible = false;
            groupBoxDrinks.Visible = false;
            listViewMenu.Items.Clear();
            buttonStartersDinner.ForeColor = Color.Blue;
            buttonEntDinner.ForeColor = Color.Black;
            buttonMainsDinner.ForeColor = Color.Black;
            buttonDessertsDinner.ForeColor = Color.Black;
            List<Dish> dinnerMenu = _dishService.GetDinnerDishes();
            List<Dish> starters = dinnerMenu.Where(a => a.DishType == 0).ToList();
            foreach (Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonDrinks_Click(object sender, EventArgs e)
        {
            buttonAddDish.Visible = false;
            buttonAddDrinks.Visible = true;
            buttonLunch.BackColor = Color.White;
            buttonDinner.BackColor = Color.White;
            buttonDrinks.BackColor = Color.DodgerBlue;
            groupBoxLunch.Visible = false;
            groupBoxDinner.Visible = false;
            groupBoxDrinks.Visible = true;
            listViewMenu.Items.Clear();
            buttonSoft.ForeColor = Color.Blue;
            buttonBeer.ForeColor = Color.Black;
            buttonWine.ForeColor = Color.Black;
            buttonSpirits.ForeColor = Color.Black;
            buttonWarm.ForeColor = Color.Black;
            List<Drink> drinks = _drinkService.GetSoftDrinks();
            foreach (Drink drink in drinks)
            {
                string[] items = { drink.ItemId.ToString(), drink.ItemName, drink.Price.ToString(), drink.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }

        }

        private void buttonStartersDinner_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonStartersDinner.ForeColor = Color.Blue;
            buttonEntDinner.ForeColor = Color.Black;
            buttonMainsDinner.ForeColor = Color.Black;
            buttonDessertsDinner.ForeColor = Color.Black;
            List<Dish> dinnerMenu = _dishService.GetDinnerDishes();
            List<Dish> starters = dinnerMenu.Where(a => a.DishType == 0).ToList();
            foreach (Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonEntDinner_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonStartersDinner.ForeColor = Color.Black;
            buttonEntDinner.ForeColor = Color.Blue;
            buttonMainsDinner.ForeColor = Color.Black;
            buttonDessertsDinner.ForeColor = Color.Black;
            List<Dish> dinnerMenu = _dishService.GetDinnerDishes();
            List<Dish> starters = dinnerMenu.Where(a => a.DishType == 3).ToList();
            foreach (Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonMainsDinner_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonStartersDinner.ForeColor = Color.Black;
            buttonEntDinner.ForeColor = Color.Black;
            buttonMainsDinner.ForeColor = Color.Blue;
            buttonDessertsDinner.ForeColor = Color.Black;
            List<Dish> dinnerMenu = _dishService.GetDinnerDishes();
            List<Dish> starters = dinnerMenu.Where(a => a.DishType == 1).ToList();
            foreach (Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonDessertsDinner_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonStartersDinner.ForeColor = Color.Black;
            buttonEntDinner.ForeColor = Color.Black;
            buttonMainsDinner.ForeColor = Color.Black;
            buttonDessertsDinner.ForeColor = Color.Blue;
            List<Dish> dinnerMenu = _dishService.GetDinnerDishes();
            List<Dish> starters = dinnerMenu.Where(a => a.DishType == 2).ToList();
            foreach (Dish dish in starters)
            {
                string[] items = { dish.ItemId.ToString(), dish.ItemName, dish.Price.ToString(), dish.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonSoft_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonSoft.ForeColor = Color.Blue;
            buttonBeer.ForeColor = Color.Black;
            buttonWine.ForeColor = Color.Black;
            buttonSpirits.ForeColor = Color.Black;
            buttonWarm.ForeColor = Color.Black;
            List<Drink> drinks = _drinkService.GetSoftDrinks();
            foreach (Drink drink in drinks)
            {
                string[] items = { drink.ItemId.ToString(), drink.ItemName, drink.Price.ToString(), drink.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonBeer_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonSoft.ForeColor = Color.Black;
            buttonBeer.ForeColor = Color.Blue;
            buttonWine.ForeColor = Color.Black;
            buttonSpirits.ForeColor = Color.Black;
            buttonWarm.ForeColor = Color.Black;
            List<Drink> drinks = _drinkService.GetBeers();
            foreach (Drink drink in drinks)
            {
                string[] items = { drink.ItemId.ToString(), drink.ItemName, drink.Price.ToString(), drink.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonWine_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonSoft.ForeColor = Color.Black;
            buttonBeer.ForeColor = Color.Black;
            buttonWine.ForeColor = Color.Blue;
            buttonSpirits.ForeColor = Color.Black;
            buttonWarm.ForeColor = Color.Black;
            List<Drink> drinks = _drinkService.GetWines();
            foreach (Drink drink in drinks)
            {
                string[] items = { drink.ItemId.ToString(), drink.ItemName, drink.Price.ToString(), drink.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonSpirits_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonSoft.ForeColor = Color.Black;
            buttonBeer.ForeColor = Color.Black;
            buttonWine.ForeColor = Color.Black;
            buttonSpirits.ForeColor = Color.Blue;
            buttonWarm.ForeColor = Color.Black;
            List<Drink> drinks = _drinkService.GetSpirits();
            foreach (Drink drink in drinks)
            {
                string[] items = { drink.ItemId.ToString(), drink.ItemName, drink.Price.ToString(), drink.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonWarm_Click(object sender, EventArgs e)
        {
            listViewMenu.Items.Clear();
            buttonSoft.ForeColor = Color.Black;
            buttonBeer.ForeColor = Color.Black;
            buttonWine.ForeColor = Color.Black;
            buttonSpirits.ForeColor = Color.Black;
            buttonWarm.ForeColor = Color.Blue;
            List<Drink> drinks = _drinkService.GetWarmDrinks();
            foreach (Drink drink in drinks)
            {
                string[] items = { drink.ItemId.ToString(), drink.ItemName, drink.Price.ToString(), drink.Stock.ToString() };
                ListViewItem li = new ListViewItem(items);
                listViewMenu.Items.Add(li);
            }
        }

        private void buttonAddDrinks_Click(object sender, EventArgs e)
        {
            if (listViewMenu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a Drink!");
                return;
            }
            var selectedRow = listViewMenu.SelectedItems[0];
            Drink drink = _drinkService.GetDrinkById(int.Parse(selectedRow.SubItems[0].Text));
            Order order = new Order()
            {
                BillId = _bill.BillId,
                TableId = _table.Id,
                Quantity = int.Parse(textBoxQuantity.Text)
            };
            _bill.Orders.Add(order);
            _orderService.CreateOrder(order, drink);
            List<Order> orders = _orderService.GetAllOrdersForTable(_table.Id);
            DisplayOrders(orders);
        }

        private void buttonReduceOne_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an Item!");
                return;
            }
            var selectedRow = listViewOrders.SelectedItems[0];
            int orderId = int.Parse(selectedRow.SubItems[0].Text);
            int quantity = int.Parse(selectedRow.SubItems[2].Text.Remove(0,1));
            if(quantity-1==0)
            {
                _orderService.DeleterOrder(orderId);
            }
            else
            {
                string comment = selectedRow.SubItems[4].Text;
                _orderService.UpdateOrder(orderId, quantity - 1, comment);
            }
            List<Order> orders = _orderService.GetAllOrdersForTable(_table.Id);
            DisplayOrders(orders);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an Item!");
                return;
            }
            var selectedRow = listViewOrders.SelectedItems[0];
            int orderId = int.Parse(selectedRow.SubItems[0].Text);
            _orderService.DeleterOrder(orderId);
            List<Order> orders = _orderService.GetAllOrdersForTable(_table.Id);
            DisplayOrders(orders);
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an Item!");
                return;
            }
            panelComment.Visible = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            var selectedRow = listViewOrders.SelectedItems[0];
            int orderId = int.Parse(selectedRow.SubItems[0].Text);
            int quantity = int.Parse(selectedRow.SubItems[2].Text.Remove(0, 1));
            if(textBoxComment.Text=="")
            {
                MessageBox.Show("Add a comment!");
            }
            else
            {
                string comment = textBoxComment.Text;
                _orderService.UpdateOrder(orderId, quantity, comment);
                List<Order> orders = _orderService.GetAllOrdersForTable(_table.Id);
                DisplayOrders(orders);
            }
        }

        private void buttonCloseComment_Click(object sender, EventArgs e)
        {
            panelComment.Visible = false;
        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            //RP coding this:
            Payment payementForm = new Payment(_table, _bill);
            payementForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();

                this.Close();
                login.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm(_staff);
            this.Close();
            tableForm.Show();
        }
    }
}
