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
            btnUpdateFeedback.Enabled = false;
            RBFeedbackIsRead.Enabled = false;
            RBFeedbackIsUnread.Enabled = false;

            btnUpdateQuestion.Enabled = false;
            RBQuestionIsRead.Enabled = false;
            RBQuesntionIsUnread.Enabled = false;
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
            txtIdFeedback.Clear();

            btnUpdateQuestion.Enabled = true;
            RBQuestionIsRead.Enabled = true;
            RBQuesntionIsUnread.Enabled = true;

            btnUpdateFeedback.Enabled = false;
            RBFeedbackIsRead.Enabled = false;
            RBFeedbackIsUnread.Enabled = false;

            using (var db = new GameDBContext(Program.ConnectionString))
            {
                var question = db.Questions.ToList();
                dgvData.DataSource = question;
                txtIdQuestion.DataBindings.Clear();
                txtIdQuestion.DataBindings.Add("Text", question, "IdQuestion");
            }
            
        }

        private void LoadFeedbackData()
        {
            txtIdQuestion.Clear();

            btnUpdateFeedback.Enabled = true;
            RBFeedbackIsRead.Enabled = true;
            RBFeedbackIsUnread.Enabled = true;

            btnUpdateQuestion.Enabled = false;
            RBQuestionIsRead.Enabled = false;
            RBQuesntionIsUnread.Enabled = false;

            using (var db = new GameDBContext(Program.ConnectionString))
            {
                var feedback = db.Feedbacks.ToList();
                dgvData.DataSource = feedback;
                txtIdFeedback.DataBindings.Clear();
                txtIdFeedback.DataBindings.Add("Text", feedback, "IdFeedback");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateFeedback_Click(object sender, EventArgs e)
        {
            int IdFeedback = int.Parse(txtIdFeedback.Text);
            bool IsRead = RBFeedbackIsRead.Checked;
            bool IsUnread = RBFeedbackIsUnread.Checked;

            //tìm kiếm để đưa lại thông tin cũ vào
            Feedback? feedback = null;
            using var context = new GameDBContext(Program.ConnectionString);
            feedback = context.Feedbacks.SingleOrDefault(c => c.IdFeedback == int.Parse(txtIdQuestion.Text));

            if (feedback != null)
            {
                if (IsRead == true && IsUnread == false)
                {
                    feedback.IsRead = IsRead;
                }
                else if (IsUnread == true && IsRead == false)
                {
                    feedback.IsRead = false;
                }

                else if (IsUnread == false && IsRead == false)
                {
                    MessageBox.Show("Are you Read or not?!", "ERROR");
                }
                var check = context.Feedbacks.Update(feedback);
                if (check != null)
                {
                    context.SaveChanges();
                    MessageBox.Show("Feedback is read!", "NOTIFICATION");
                }
            }

        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            int IdQuestion = int.Parse(txtIdQuestion.Text);
            bool IsRead = RBQuestionIsRead.Checked;
            bool IsUnread = RBQuesntionIsUnread.Checked;

            //tìm kiếm để đưa lại thông tin cũ vào
            Question ?question = null;
            using var context = new GameDBContext(Program.ConnectionString);
            question = context.Questions.SingleOrDefault(c => c.IdQuestion == int.Parse(txtIdQuestion.Text));

            if (question != null)
            {
                if (IsRead == true && IsUnread == false)
                {
                    question.IsRead = IsRead;
                }
                else if (IsUnread == true && IsRead == false)
                {
                    question.IsRead = false;
                }

                else if (IsUnread == false && IsRead == false)
                {
                    MessageBox.Show("Are you Read or not?!", "ERROR");
                }    
                var check = context.Questions.Update(question);
                if (check != null)
                {
                    context.SaveChanges();
                    MessageBox.Show("Question is updated!", "NOTIFICATION");
                }
            }
        }
    }
}
