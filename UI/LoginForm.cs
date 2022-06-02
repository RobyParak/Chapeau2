using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;
using UI;
using static Model.Staff;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                StaffService staffService = new StaffService();
                Staff staff = staffService.LoginStaff(int.Parse(txtStaffID.Text), int.Parse(txtPassword.Text));


                if (staff.StaffRole == Role.Waiter)
                {
                    TableForm tableForm = new TableForm();
                    tableForm.ShowDialog();
                }
                else if (staff.StaffRole == Role.Bartender)
                {
                    BarViewForm barViewForm = new BarViewForm();
                    barViewForm.ShowDialog();
                }
                else if (staff.StaffRole == Role.Chef)
                {
                    KitchenViewForm kitchenViewForm = new KitchenViewForm();
                    kitchenViewForm.ShowDialog();
                }
                else
                {
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.ShowDialog();
                }
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect username or password!\nTry again");
            }
        }
    }
}
