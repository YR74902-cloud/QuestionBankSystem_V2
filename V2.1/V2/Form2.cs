using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class Form2 : Form
    {
        private List<Question> questions = new List<Question>();
        private Question? questionToEdit;
        private bool isEditing = false;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        public Form2(List<Question> questions, Question question)
        {
            InitializeComponent();
            this.questions = questions;
            questionToEdit = question;
            isEditing = true;
            lblTitle.Text = "Edit Question";
            txtQuestion.Text = question.QuestionText;
            txtOption1.Text = question.Option1;
            txtOption2.Text = question.Option2;
            txtOption3.Text = question.Option3;
            txtOption4.Text = question.Option4;
            cmbSubject.SelectedItem = question.Subject;
            cmbDifficulty.SelectedItem = question.Difficulty;
            cmbCorrectAnswer.SelectedItem = question.CorrectAnswer;
            btnSave.Text = "Update";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the question.");
                txtQuestion.Focus();
                return;
            }
            if (txtOption1.Text.Trim() == "" || txtOption2.Text.Trim() == "" || txtOption3.Text.Trim() == "" || txtOption4.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all four options.");
                return;
            }
            if (cmbSubject.SelectedIndex == -1 || cmbDifficulty.SelectedIndex == -1 || cmbCorrectAnswer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select subject, difficulty and correct answer.");
                return;
            }

            if (isEditing && questionToEdit != null)
            {
                questionToEdit.QuestionText = txtQuestion.Text.Trim();
                questionToEdit.Option1 = txtOption1.Text.Trim();
                questionToEdit.Option2 = txtOption2.Text.Trim();
                questionToEdit.Option3 = txtOption3.Text.Trim();
                questionToEdit.Option4 = txtOption4.Text.Trim();
                questionToEdit.Subject = cmbSubject.Text;
                questionToEdit.Difficulty = cmbDifficulty.Text;
                questionToEdit.CorrectAnswer = cmbCorrectAnswer.Text;
            }
            else
            {
                Question newQuestion = new Question();
                newQuestion.QuestionText = txtQuestion.Text.Trim();
                newQuestion.Option1 = txtOption1.Text.Trim();
                newQuestion.Option2 = txtOption2.Text.Trim();
                newQuestion.Option3 = txtOption3.Text.Trim();
                newQuestion.Option4 = txtOption4.Text.Trim();
                newQuestion.Subject = cmbSubject.Text;
                newQuestion.Difficulty = cmbDifficulty.Text;
                newQuestion.CorrectAnswer = cmbCorrectAnswer.Text;
                questions.Add(newQuestion);
            }

            MessageBox.Show(isEditing ? "Question updated successfully." : "Question added successfully.");
            if (isEditing)
                Close();
            else
            {
                txtQuestion.Clear();
                txtOption1.Clear();
                txtOption2.Clear();
                txtOption3.Clear();
                txtOption4.Clear();
                cmbSubject.SelectedIndex = -1;
                cmbDifficulty.SelectedIndex = -1;
                cmbCorrectAnswer.SelectedIndex = -1;
            }
        }
    }
}
