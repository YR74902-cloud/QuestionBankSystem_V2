namespace QuestionBankSystem
{
    partial class RegisterForm
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
            lblConfirmPassword = new Label();
            lblRole = new Label();
            lblCode = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtInstructorCode = new TextBox();
            cmbRole = new ComboBox();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(145, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 37);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Create Account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(85, 115);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(76, 19);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.Location = new Point(85, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 19);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmPassword.Location = new Point(85, 215);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(131, 19);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRole.Location = new Point(85, 265);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(99, 19);
            lblRole.TabIndex = 8;
            lblRole.Text = "Account Type";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCode.Location = new Point(85, 315);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(112, 19);
            lblCode.TabIndex = 7;
            lblCode.Text = "Instructor Code";
            lblCode.Visible = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(250, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(250, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(250, 210);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(190, 23);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtInstructorCode
            // 
            txtInstructorCode.Location = new Point(250, 310);
            txtInstructorCode.Name = "txtInstructorCode";
            txtInstructorCode.Size = new Size(190, 23);
            txtInstructorCode.TabIndex = 3;
            txtInstructorCode.UseSystemPasswordChar = true;
            txtInstructorCode.Visible = false;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Student", "Instructor" });
            cmbRole.Location = new Point(250, 260);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(190, 23);
            cmbRole.TabIndex = 2;
            cmbRole.SelectedIndexChanged += CmbRole_SelectedIndexChanged;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkSlateGray;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(266, 385);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(160, 42);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += CreateButton_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSlateGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(84, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 42);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += CancelButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(520, 520);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(cmbRole);
            Controls.Add(txtInstructorCode);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblCode);
            Controls.Add(lblRole);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle, lblUsername, lblPassword, lblConfirmPassword, lblRole, lblCode;
        private TextBox txtUsername, txtPassword, txtConfirmPassword, txtInstructorCode;
        private ComboBox cmbRole;
        private Button btnCreate, btnCancel;
    }
}
