using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form5 : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            score = 0;
            ShowCurrentQuestion();
        }

        private void ShowCurrentQuestion()
        {
            Question question = questions[currentQuestionIndex];
            lblQuestion.Text = question.QuestionText;
            rdoOption1.Text = question.Option1;
            rdoOption2.Text = question.Option2;
            rdoOption3.Text = question.Option3;
            rdoOption4.Text = question.Option4;
            rdoOption1.Checked = false;
            rdoOption2.Checked = false;
            rdoOption3.Checked = false;
            rdoOption4.Checked = false;
            lblProgress.Text = "Question " + (currentQuestionIndex + 1) + " of " + questions.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!rdoOption1.Checked && !rdoOption2.Checked && !rdoOption3.Checked && !rdoOption4.Checked)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }
            string selectedAnswer = "";
            if (rdoOption1.Checked)
                selectedAnswer = "Option 1";
            else if (rdoOption2.Checked)
                selectedAnswer = "Option 2";
            else if (rdoOption3.Checked)
                selectedAnswer = "Option 3";
            else if (rdoOption4.Checked)
                selectedAnswer = "Option 4";

            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
                score++;

            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                ShowCurrentQuestion();
            }
            else
            {
                using (ResultForm result = new ResultForm(score, questions.Count))
                {
                    result.ShowDialog();
                }
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
