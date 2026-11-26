namespace QuestionBankSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(85, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 38);
            lblTitle.Text = "Question Bank System";
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsername.Location = new Point(75, 135);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username";
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPassword.Location = new Point(75, 195);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Password";
            txtUsername.Location = new Point(180, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(235, 27);
            txtPassword.Location = new Point(180, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(235, 27);
            txtPassword.UseSystemPasswordChar = true;
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(90, 270);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 42);
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += LoginButton_Click;
            btnRegister.BackColor = Color.DarkSlateGray;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(255, 270);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 42);
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += RegisterButton_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 430);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Question Bank System - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
    }
}
