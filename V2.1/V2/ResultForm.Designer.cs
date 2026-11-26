namespace QuestionBankSystem
{
    partial class ResultForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            lblTitle = new Label(); lblScore = new Label(); lblPercentage = new Label(); pnlResult = new Panel(); btnClose = new Button(); SuspendLayout();
            lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold); lblTitle.ForeColor = Color.DarkSlateGray; lblTitle.Location = new Point(145, 35); lblTitle.Text = "Quiz Completed";
            lblScore.AutoSize = true; lblScore.Font = new Font("Segoe UI", 17F, FontStyle.Bold); lblScore.Location = new Point(175, 105); lblScore.Text = "Your Score";
            lblPercentage.AutoSize = true; lblPercentage.Font = new Font("Segoe UI", 13F); lblPercentage.Location = new Point(205, 150); lblPercentage.Text = "Percentage";
            pnlResult.BackColor = Color.White; pnlResult.Location = new Point(70, 205); pnlResult.Size = new Size(400, 85); pnlResult.Paint += PnlResult_Paint;
            btnClose.BackColor = Color.DarkSlateGray; btnClose.FlatStyle = FlatStyle.Flat; btnClose.ForeColor = Color.White; btnClose.Location = new Point(205, 320); btnClose.Size = new Size(140, 42); btnClose.Text = "Close"; btnClose.UseVisualStyleBackColor = false; btnClose.Click += CloseButton_Click;
            AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; BackColor = Color.WhiteSmoke; ClientSize = new Size(560, 430); Controls.Add(btnClose); Controls.Add(pnlResult); Controls.Add(lblPercentage); Controls.Add(lblScore); Controls.Add(lblTitle); FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false; Name = "ResultForm"; StartPosition = FormStartPosition.CenterParent; Text = "Quiz Result"; ResumeLayout(false); PerformLayout();
        }
        private Label lblTitle, lblScore, lblPercentage;
        private Panel pnlResult;
        private Button btnClose;
    }
}
