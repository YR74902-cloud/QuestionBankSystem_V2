using System;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void CmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isInstructor = cmbRole.Text == "Instructor";
            lblCode.Visible = isInstructor;
            txtInstructorCode.Visible = isInstructor;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            foreach (User user in AppData.Users)
            {
                if (user.Username == txtUsername.Text.Trim())
                {
                    MessageBox.Show("This username already exists.");
                    return;
                }
            }
            if (cmbRole.Text == "Instructor" && txtInstructorCode.Text != AppData.InstructorCode)
            {
                MessageBox.Show("Incorrect instructor code.");
                return;
            }
            User newUser = new User();
            newUser.Username = txtUsername.Text.Trim();
            newUser.Password = txtPassword.Text;
            newUser.Role = cmbRole.Text;
            AppData.Users.Add(newUser);
            MessageBox.Show("Account created successfully.");
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
