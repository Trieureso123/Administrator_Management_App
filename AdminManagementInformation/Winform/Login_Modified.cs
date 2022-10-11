using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Login_modifier : Form
    {
        public Login_modifier()
        {
            InitializeComponent();
            
            //Error notification hiding
            lbBothErr.Hide();
            lbPasswordErr.Hide();
            lbUsernameErr.Hide();
            lbLoginErr.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool checkvalidation = TypingValidation(username, password);

            if (checkvalidation)
            {
                string? cs = Program.ConnectionString;
                using (var db = new GameDBContext(cs))
                {
                    var AdminInformation = db.Accounts.Where(a => a.Username == username
                    && a.Password == password).FirstOrDefault();

                    if(AdminInformation == null)
                    {
                        lbLoginErr.Show();
                        lbPasswordErr.Hide();
                        lbBothErr.Hide();
                        lbUsernameErr.Hide();
                    }

                    else if (AdminInformation != null)
                    {
                        //Correct account
                        Main Mainfrm = new Main();
                        this.Hide();
                        Mainfrm.Show();
                    }
                }
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            PanelUsername.BackColor = Color.White;
            PanelPassword.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            PanelPassword.BackColor = Color.White;
            PanelUsername.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
        }

        private void lbPassword_Click(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void lbPassword_Clickup(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //function
        public bool TypingValidation(string username, string password)
        {
            if (username == "")
            {
                lbPasswordErr.Hide();
                lbBothErr.Hide();
                lbUsernameErr.Show();
                return false;
            }

            else if (password == "")
            {
                lbBothErr.Hide();
                lbUsernameErr.Hide();
                lbPasswordErr.Show();
                return false;
            }

            else if (username == "" && password == "")
            {
                lbUsername.Hide();
                lbPasswordErr.Hide();
                lbBothErr.Show();
                return false;
            }
            return true;
        }

    }
}
