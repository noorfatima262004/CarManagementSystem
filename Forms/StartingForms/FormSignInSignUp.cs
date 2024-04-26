using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.BL;
using FinalProjectDB.Forms;
using FinalProjectDB.Forms.Admin;

namespace FinalProjectDB.Forms.StartingForms
{
    public partial class FormSignInSignUp : Form
    {
        public FormSignInSignUp()
        {
            InitializeComponent();
            startup();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void startup()
        {
            this.SignInPannel.Show();
            this.SignUpPannel.Hide();
        }
        private void SignUpPannelShow()
        {
            this.SignInPannel.Hide();
            this.SignUpPannel.Show();
        }

        private (string,string) InputSignUp()
        {
            string name = SignUpName.Text;
            string pass = Password.Text;
            return (name, pass);
            
        }
        private (string, string) InputSignIn()
        {
            string name = Name.Text;
            string pass = SignInPassword.Text;
            return (name, pass);
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            SignUpPannelShow();
           
        }

        private void SignIn_Click_1(object sender, EventArgs e)
        {
            try
            {
                (string Name, string pass) = InputSignIn();

                FinalProjectDB.BL.Customer customer = new FinalProjectDB.BL.Customer(DateTime.Now, Name, pass);

                (string user, int userId) = customer.SignIn(Name, pass);
                if (user == "Admin"){
                    MessageBox.Show("Welcome to Admin DashBoard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashBoard adminForm = new AdminDashBoard(userId);
                    adminForm.Show();
                }
                if (user == "Employee") { 
                    MessageBox.Show("Welcome to Admin DashBoard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (user == "Customer"){
                    MessageBox.Show("Welcome to Admin DashBoard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (user == null) MessageBox.Show("No User Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            (string Name, string pass) = InputSignUp();
            FinalProjectDB.BL.Customer customer = new FinalProjectDB.BL.Customer(DateTime.Now, Name, pass);
            customer.SignUp();
        }
    }
}
