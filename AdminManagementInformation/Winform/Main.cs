using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close whole app
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login_modifier login = new Login_modifier();
            this.Hide();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //nothing
        }

        private void btnLoadFeedback_Click(object sender, EventArgs e)
        {
            LoadFeedbackData();
        }

        private void btnLoadQuestion_Click(object sender, EventArgs e)
        {
            LoadQuestionData();
        }

        private void LoadQuestionData()
        {
            using (var db = new GameWebsiteDbContext(Program.ConnectionString))
            {
                dgvData.DataSource = db.Questions.ToList();
            }
        }

        private void LoadFeedbackData()
        {
            using (var db = new GameWebsiteDbContext(Program.ConnectionString))
            {
                dgvData.DataSource = db.Feedbacks.ToList();
            }
        }
    }
}
