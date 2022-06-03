using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Model;
using Login;

namespace UI
{
    public partial class TableForm : Form
    {
        private Logic.TableService tableService;


        private List<Table> tableList;
        private List<Button> buttonList;

        public TableForm()
        {
            TableStatus();
        }

        public TableForm(Staff staff)
        {
            InitializeComponent();

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

            TableStatus();

            btnLogout.Text = "Logout";
            lblLogout.Text = "Logged in as: " + staff.FirstName;
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
            if (tableList[0].TableStatus == 0)
            {
                SeatTable(tableList[0].Id);
            }
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            if (tableList[1].TableStatus == 0)
            {
                SeatTable(tableList[1].Id);
            }
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            if (tableList[2].TableStatus == 0)
            {
                SeatTable(tableList[2].Id);
            }
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            if (tableList[3].TableStatus == 0)
            {
                SeatTable(tableList[3].Id);
            }
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            if (tableList[4].TableStatus == 0)
            {
                SeatTable(tableList[4].Id);
            }
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            if (tableList[5].TableStatus == 0)
            {
                SeatTable(tableList[5].Id);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tableList[6].TableStatus == 0)
            {
                SeatTable(tableList[6].Id);
            }
        }
        private void btnTable8_Click(object sender, EventArgs e)
        {
            if (tableList[7].TableStatus == 0)
            {
                SeatTable(tableList[7].Id);
            }
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            if (tableList[8].TableStatus == 0)
            {
                SeatTable(tableList[8].Id);
            }
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            if (tableList[9].TableStatus == 0)
            {
                SeatTable(tableList[9].Id);
            }
        }
    }
}
