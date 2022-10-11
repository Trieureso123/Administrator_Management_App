namespace Winform
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBQuestionIsRead = new System.Windows.Forms.RadioButton();
            this.RBQuesntionIsUnread = new System.Windows.Forms.RadioButton();
            this.RBFeedbackIsRead = new System.Windows.Forms.RadioButton();
            this.RBFeedbackIsUnread = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIDQuestion = new System.Windows.Forms.Label();
            this.lbIsRead = new System.Windows.Forms.Label();
            this.lbIDFeedback = new System.Windows.Forms.Label();
            this.txtIdQuestion = new System.Windows.Forms.TextBox();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.txtIdFeedback = new System.Windows.Forms.TextBox();
            this.btnUpdateFeedback = new System.Windows.Forms.Button();
            this.btnLoadFeedback = new System.Windows.Forms.Button();
            this.btnLoadQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBQuestionIsRead);
            this.panel1.Controls.Add(this.RBQuesntionIsUnread);
            this.panel1.Controls.Add(this.RBFeedbackIsRead);
            this.panel1.Controls.Add(this.RBFeedbackIsUnread);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbIDQuestion);
            this.panel1.Controls.Add(this.lbIsRead);
            this.panel1.Controls.Add(this.lbIDFeedback);
            this.panel1.Controls.Add(this.txtIdQuestion);
            this.panel1.Controls.Add(this.btnUpdateQuestion);
            this.panel1.Controls.Add(this.txtIdFeedback);
            this.panel1.Controls.Add(this.btnUpdateFeedback);
            this.panel1.Controls.Add(this.btnLoadFeedback);
            this.panel1.Controls.Add(this.btnLoadQuestion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 433);
            this.panel1.TabIndex = 0;
            // 
            // RBQuestionIsRead
            // 
            this.RBQuestionIsRead.AutoSize = true;
            this.RBQuestionIsRead.Checked = true;
            this.RBQuestionIsRead.Location = new System.Drawing.Point(529, 99);
            this.RBQuestionIsRead.Name = "RBQuestionIsRead";
            this.RBQuestionIsRead.Size = new System.Drawing.Size(51, 19);
            this.RBQuestionIsRead.TabIndex = 14;
            this.RBQuestionIsRead.TabStop = true;
            this.RBQuestionIsRead.Text = "Read";
            this.RBQuestionIsRead.UseVisualStyleBackColor = true;
            // 
            // RBQuesntionIsUnread
            // 
            this.RBQuesntionIsUnread.AutoSize = true;
            this.RBQuesntionIsUnread.Location = new System.Drawing.Point(629, 99);
            this.RBQuesntionIsUnread.Name = "RBQuesntionIsUnread";
            this.RBQuesntionIsUnread.Size = new System.Drawing.Size(63, 19);
            this.RBQuesntionIsUnread.TabIndex = 14;
            this.RBQuesntionIsUnread.Text = "Unread";
            this.RBQuesntionIsUnread.UseVisualStyleBackColor = true;
            // 
            // RBFeedbackIsRead
            // 
            this.RBFeedbackIsRead.AutoSize = true;
            this.RBFeedbackIsRead.Location = new System.Drawing.Point(136, 98);
            this.RBFeedbackIsRead.Name = "RBFeedbackIsRead";
            this.RBFeedbackIsRead.Size = new System.Drawing.Size(51, 19);
            this.RBFeedbackIsRead.TabIndex = 14;
            this.RBFeedbackIsRead.Text = "Read";
            this.RBFeedbackIsRead.UseVisualStyleBackColor = true;
            // 
            // RBFeedbackIsUnread
            // 
            this.RBFeedbackIsUnread.AutoSize = true;
            this.RBFeedbackIsUnread.Location = new System.Drawing.Point(236, 98);
            this.RBFeedbackIsUnread.Name = "RBFeedbackIsUnread";
            this.RBFeedbackIsUnread.Size = new System.Drawing.Size(63, 19);
            this.RBFeedbackIsUnread.TabIndex = 14;
            this.RBFeedbackIsUnread.Text = "Unread";
            this.RBFeedbackIsUnread.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(463, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Read";
            // 
            // lbIDQuestion
            // 
            this.lbIDQuestion.AutoSize = true;
            this.lbIDQuestion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIDQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbIDQuestion.Location = new System.Drawing.Point(396, 66);
            this.lbIDQuestion.Name = "lbIDQuestion";
            this.lbIDQuestion.Size = new System.Drawing.Size(115, 22);
            this.lbIDQuestion.TabIndex = 11;
            this.lbIDQuestion.Text = "Id Question";
            // 
            // lbIsRead
            // 
            this.lbIsRead.AutoSize = true;
            this.lbIsRead.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIsRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbIsRead.Location = new System.Drawing.Point(70, 94);
            this.lbIsRead.Name = "lbIsRead";
            this.lbIsRead.Size = new System.Drawing.Size(60, 22);
            this.lbIsRead.TabIndex = 11;
            this.lbIsRead.Text = "Read";
            // 
            // lbIDFeedback
            // 
            this.lbIDFeedback.AutoSize = true;
            this.lbIDFeedback.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIDFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lbIDFeedback.Location = new System.Drawing.Point(3, 64);
            this.lbIDFeedback.Name = "lbIDFeedback";
            this.lbIDFeedback.Size = new System.Drawing.Size(127, 22);
            this.lbIDFeedback.TabIndex = 11;
            this.lbIDFeedback.Text = "Id Feedback";
            // 
            // txtIdQuestion
            // 
            this.txtIdQuestion.Location = new System.Drawing.Point(529, 67);
            this.txtIdQuestion.Name = "txtIdQuestion";
            this.txtIdQuestion.ReadOnly = true;
            this.txtIdQuestion.Size = new System.Drawing.Size(191, 23);
            this.txtIdQuestion.TabIndex = 9;
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateQuestion.FlatAppearance.BorderSize = 0;
            this.btnUpdateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdateQuestion.Location = new System.Drawing.Point(529, 134);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(191, 32);
            this.btnUpdateQuestion.TabIndex = 7;
            this.btnUpdateQuestion.Text = "Update Question";
            this.btnUpdateQuestion.UseVisualStyleBackColor = true;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // txtIdFeedback
            // 
            this.txtIdFeedback.Location = new System.Drawing.Point(136, 63);
            this.txtIdFeedback.Name = "txtIdFeedback";
            this.txtIdFeedback.ReadOnly = true;
            this.txtIdFeedback.Size = new System.Drawing.Size(191, 23);
            this.txtIdFeedback.TabIndex = 9;
            // 
            // btnUpdateFeedback
            // 
            this.btnUpdateFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateFeedback.FlatAppearance.BorderSize = 0;
            this.btnUpdateFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFeedback.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUpdateFeedback.Location = new System.Drawing.Point(100, 134);
            this.btnUpdateFeedback.Name = "btnUpdateFeedback";
            this.btnUpdateFeedback.Size = new System.Drawing.Size(191, 32);
            this.btnUpdateFeedback.TabIndex = 7;
            this.btnUpdateFeedback.Text = "Update Feedback";
            this.btnUpdateFeedback.UseVisualStyleBackColor = true;
            this.btnUpdateFeedback.Click += new System.EventHandler(this.btnUpdateFeedback_Click);
            // 
            // btnLoadFeedback
            // 
            this.btnLoadFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadFeedback.FlatAppearance.BorderSize = 0;
            this.btnLoadFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadFeedback.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLoadFeedback.Location = new System.Drawing.Point(90, 334);
            this.btnLoadFeedback.Name = "btnLoadFeedback";
            this.btnLoadFeedback.Size = new System.Drawing.Size(190, 32);
            this.btnLoadFeedback.TabIndex = 7;
            this.btnLoadFeedback.Text = "Load Feedback ";
            this.btnLoadFeedback.UseVisualStyleBackColor = true;
            this.btnLoadFeedback.Click += new System.EventHandler(this.btnLoadFeedback_Click);
            // 
            // btnLoadQuestion
            // 
            this.btnLoadQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadQuestion.FlatAppearance.BorderSize = 0;
            this.btnLoadQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadQuestion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoadQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLoadQuestion.Location = new System.Drawing.Point(438, 334);
            this.btnLoadQuestion.Name = "btnLoadQuestion";
            this.btnLoadQuestion.Size = new System.Drawing.Size(190, 32);
            this.btnLoadQuestion.TabIndex = 8;
            this.btnLoadQuestion.Text = "Load Question";
            this.btnLoadQuestion.UseVisualStyleBackColor = true;
            this.btnLoadQuestion.Click += new System.EventHandler(this.btnLoadQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(12, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Casual Game Development Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Design by";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(0, 181);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(759, 129);
            this.dgvData.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogout.Location = new System.Drawing.Point(660, 389);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 42);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Administrator Form";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMinimize.Location = new System.Drawing.Point(668, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 33);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.Location = new System.Drawing.Point(715, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 432);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadFeedback;
        private System.Windows.Forms.Button btnLoadQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdFeedback;
        private System.Windows.Forms.Button btnUpdateFeedback;
        private System.Windows.Forms.TextBox txtIdQuestion;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.Label lbIsRead;
        private System.Windows.Forms.Label lbIDFeedback;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIDQuestion;
        private System.Windows.Forms.RadioButton RBQuestionIsRead;
        private System.Windows.Forms.RadioButton RBQuesntionIsUnread;
        private System.Windows.Forms.RadioButton RBFeedbackIsRead;
        private System.Windows.Forms.RadioButton RBFeedbackIsUnread;
    }
}