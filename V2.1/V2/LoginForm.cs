using System;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            foreach (User user in AppData.Users)
            {
                if (user.Username == txtUsername.Text.Trim() && user.Password == txtPassword.Text)
                {
                    AppData.CurrentUser = user;
                    Hide();
                    using (Form1 mainForm = new Form1())
                    {
                        mainForm.ShowDialog();
                    }
                    Show();
                    txtPassword.Clear();
                    return;
                }
            }
            MessageBox.Show("Incorrect username or password.");
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (RegisterForm form = new RegisterForm())
            {
                form.ShowDialog();
            }
        }
    }
}
