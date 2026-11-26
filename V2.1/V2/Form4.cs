using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form4 : Form
    {
        private List<Question> questions = new List<Question>();

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || cmbDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select subject and difficulty.");
                return;
            }
            List<Question> quizQuestions = new List<Question>();
            foreach (Question question in questions)
            {
                if (question.Subject.Trim() == cmbSubject.Text.Trim() && question.Difficulty.Trim() == cmbDifficulty.Text.Trim())
                    quizQuestions.Add(question);
            }
            if (quizQuestions.Count == 0)
            {
                MessageBox.Show("No questions available for the selected subject and difficulty.");
                return;
            }
            using (Form5 form = new Form5(quizQuestions))
            {
                form.ShowDialog();
            }
        }
    }
}
