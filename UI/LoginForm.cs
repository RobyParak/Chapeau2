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
using System.Security.Cryptography;

namespace Login
{
    public partial class LoginForm : Form
    {
        private StaffService staffService;

        public LoginForm()
        {
            InitializeComponent();
            staffService = new StaffService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hash = HashPinCode(txtPassword.Text);

            try
            {
                Staff staff = staffService.LoginStaff(hash);

                if (staff.Hash != hash)
                    throw new Exception();

                RedirectStaff(staff);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect username or password!\nTry again");
            }
        }

        private string HashPinCode(string input, string salt = "InHolland")
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            var sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            //string testPinCode = Convert.ToBase64String(hash).ToString();

            //MessageBox.Show(testPinCode);
            return Convert.ToBase64String(hash);
        }

        private void RedirectStaff(Staff staff)
        {
            switch (staff.Role)
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

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact the manager for a password change");
        }
    }
}
