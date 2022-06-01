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

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                StaffService staffService = new StaffService();
                Staff staff = staffService.LoginStaff(int.Parse(txtStaffID.Text), int.Parse(txtPassword.Text));

                TableForm tableForm = new TableForm();
                this.Hide();
                tableForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect username or password!\nTry again");
            }
        }
    }
}
