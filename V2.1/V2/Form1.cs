using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form1 : Form
    {
        private List<Question> questions = AppData.Questions;

        public Form1()
        {
            InitializeComponent();
            Text = "Question Bank System - " + AppData.CurrentUser?.Role;
            lblTitle.Text = "Welcome " + AppData.CurrentUser?.Username;

            if (AppData.CurrentUser?.Role == "Instructor")
            {
                btnAddQuestion.Visible = true;
                btnDisplayQuestions.Visible = true;
                btnTakeQuiz.Visible = false;
                btnStatistics.Visible = true;
                btnAddQuestion.Location = new System.Drawing.Point(265, 180);
                btnDisplayQuestions.Location = new System.Drawing.Point(265, 260);
                btnStatistics.Location = new System.Drawing.Point(265, 340);
                btnExit.Location = new System.Drawing.Point(265, 420);
            }
            else
            {
                btnAddQuestion.Visible = false;
                btnDisplayQuestions.Visible = false;
                btnStatistics.Visible = false;
                btnTakeQuiz.Visible = true;
                btnTakeQuiz.Location = new System.Drawing.Point(265, 240);
                btnExit.Location = new System.Drawing.Point(265, 330);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisplayQuestions_Click(object sender, EventArgs e)
        {
            using (Form3 form = new Form3(questions, this))
            {
                Hide();
                form.ShowDialog();
                Show();
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            using (Form2 form = new Form2(questions))
            {
                form.ShowDialog();
            }
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            using (Form4 form = new Form4(questions))
            {
                form.ShowDialog();
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            using (StatisticsForm form = new StatisticsForm(questions))
            {
                form.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
