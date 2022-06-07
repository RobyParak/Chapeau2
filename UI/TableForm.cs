using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using Login;
using Service;

namespace UI
{
    public partial class TableForm : Form
    {
        private Logic.TableService tableService;
        private BillService billService; 

        private List<Table> tableList;
        private List<Button> buttonList;
        private int billId;
        private Staff staff;

        public TableForm()
        {
            InitializeComponent();
            TableStatus();
        }

        public TableForm(Staff staff)
        {
            InitializeComponent(); // overal

            this.staff = staff;

            tableList = new List<Table>();
            tableService = new Logic.TableService();
            billService = new BillService();

            buttonList = new List<Button>();
            buttonList.Add(btnTable1);
            buttonList.Add(btnTable2);
            buttonList.Add(btnTable3);
            buttonList.Add(btnTable4);
            buttonList.Add(btnTable5);
            buttonList.Add(btnTable6);
            buttonList.Add(btnTable7);
            buttonList.Add(btnTable8);
            buttonList.Add(btnTable9);
            buttonList.Add(btnTable10);

            TableStatus();

            btnLogout.Text = "Logout";
            lblLogout.Text = "Logged in as: " + staff.FirstName;
        }

        public TableForm(Table table, Staff staff)
        {
            InitializeComponent();

            this.staff = staff;

            tableList = new List<Table>();
            tableService = new Logic.TableService();

            buttonList = new List<Button>();
            buttonList.Add(btnTable1);
            buttonList.Add(btnTable2);
            buttonList.Add(btnTable3);
            buttonList.Add(btnTable4);
            buttonList.Add(btnTable5);
            buttonList.Add(btnTable6);
            buttonList.Add(btnTable7);
            buttonList.Add(btnTable8);
            buttonList.Add(btnTable9);
            buttonList.Add(btnTable10);

            btnLogout.Text = "Logout";
            lblLogout.Text = "Logged in as: " + staff.FirstName;

            tableService.ChangeTableToAvailable(table.Id);
            TableStatus();
        }

        private void TableStatus()
        {
            tableList = tableService.GetTableData();

            for (int i = 0; i < tableList.Count; i++)
            {
                if (tableList[i].TableStatus == 0)
                    buttonList[i].BackColor = Color.LightGray;
                else if (tableList[i].TableStatus == 1)
                    buttonList[i].BackColor = Color.SpringGreen;
                else if (tableList[i].TableStatus == 2)
                    buttonList[i].BackColor = Color.CornflowerBlue;
                else
                    buttonList[i].BackColor = Color.Gold;
            }
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


        private void SeatTable(int tableId)
        {
            DialogResult dialogResult = MessageBox.Show($"Table #{tableId} is available\nSeat table?", "Seat Table", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                tableService.SeatTable(tableId);
                TableStatus();
            }

        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[0]);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[1]);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[2]);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[3]);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[4]);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[5]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[6]);
        }
        private void btnTable8_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[7]);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[8]);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            CheckTableStatus(tableList[9]);
        }

        private void CheckTableStatus(Table table)
        {
            if (table.TableStatus == 0)
            {
                SeatTable(table.Id);
                billService.CreateEmptyBill(table.Id);
            }
            else if (table.TableStatus == 1)
            {
                Bill bill = billService.GetBillById(billService.GetBillIdByTableId(table.Id));

                tableService.ServeTable(table.Id);
                //OrderView orderView = new OrderView(table, bill, staff);
                OrderView orderView = new OrderView(table,bill,staff);
                this.Close();
                orderView.Show();              
            }
            else if (table.TableStatus == 2)
            {
                Bill bill = billService.GetBillById(billService.GetBillIdByTableId(table.Id));
                OrderView orderView = new OrderView(table, bill, staff);
                this.Close();
                orderView.Show();
            }
        }
    }
}