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

                if (staff.PassCode != int.Parse(txtPassword.Text))
                    throw new Exception();

                switch (staff.Roles)
                {
                    case RolesEnum.Waiter:
                        TableForm tableForm = new TableForm(staff);
                        tableForm.Show();
                        this.Hide();
                        break;
                    case RolesEnum.Chef:
                        KitchenViewForm kitchenViewForm = new KitchenViewForm(staff);
                        kitchenViewForm.ShowDialog();
                        this.Hide();
                        break;
                    case RolesEnum.Bartender:
                        BarViewForm barViewForm = new BarViewForm(staff);
                        barViewForm.ShowDialog();
                        this.Hide();
                        break;
                    case RolesEnum.Manager:
                        ManagerForm managerForm = new ManagerForm(staff);
                        managerForm.ShowDialog();
                        this.Hide();
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect username or password!\nTry again");
            }
        }
    }
}
