using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form3 : Form
    {
        private List<Question> questions = new List<Question>();
        private List<Question> displayedQuestions = new List<Question>();
        private Form1? mainForm;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Question> questions, Form1 mainForm)
        {
            InitializeComponent();
            this.questions = questions;
            this.mainForm = mainForm;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowQuestions(questions);
        }

        private void ShowQuestions(List<Question> list)
        {
            lstQuestions.Items.Clear();
            displayedQuestions.Clear();
            foreach (Question question in list)
            {
                displayedQuestions.Add(question);
                lstQuestions.Items.Add(question.QuestionText);
            }
            lblDetails.Text = "Select a question to view its details.";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a search word.");
                return;
            }
            List<Question> result = new List<Question>();
            foreach (Question question in questions)
            {
                if (question.QuestionText.Contains(txtSearch.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    result.Add(question);
            }
            ShowQuestions(result);
            if (result.Count == 0)
                MessageBox.Show("Question not found.");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSubject.SelectedIndex = -1;
            cmbDifficulty.SelectedIndex = -1;
            ShowQuestions(questions);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || cmbDifficulty.SelectedIndex == -1)
            {
                MessageBox.Show("Please select subject and difficulty.");
                return;
            }
            List<Question> result = new List<Question>();
            foreach (Question question in questions)
            {
                if (question.Subject == cmbSubject.Text && question.Difficulty == cmbDifficulty.Text)
                    result.Add(question);
            }
            ShowQuestions(result);
            if (result.Count == 0)
                MessageBox.Show("No questions found.");
        }

        private void lstQuestions_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndex >= 0 && lstQuestions.SelectedIndex < displayedQuestions.Count)
            {
                Question question = displayedQuestions[lstQuestions.SelectedIndex];
                lblDetails.Text = question.Subject + " | " + question.Difficulty + " | Correct answer: " + question.CorrectAnswer;
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a question.");
                return;
            }
            Question selectedQuestion = displayedQuestions[lstQuestions.SelectedIndex];
            using (Form2 form = new Form2(questions, selectedQuestion))
            {
                form.ShowDialog();
            }
            ShowQuestions(questions);
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (lstQuestions.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a question.");
                return;
            }
            Question selectedQuestion = displayedQuestions[lstQuestions.SelectedIndex];
            DialogResult result = MessageBox.Show("Delete this question?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                questions.Remove(selectedQuestion);
                ShowQuestions(questions);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm?.Show();
            Close();
        }
    }
}
