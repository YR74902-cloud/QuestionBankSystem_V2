namespace QuestionBankSystem
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            lblTitle = new Label(); lblTotal = new Label(); pnlChart = new Panel(); SuspendLayout();
            lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold); lblTitle.ForeColor = Color.DarkSlateGray; lblTitle.Location = new Point(350, 25); lblTitle.Name = "lblTitle"; lblTitle.Text = "Question Statistics";
            lblTotal.AutoSize = true; lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold); lblTotal.Location = new Point(45, 95); lblTotal.Name = "lblTotal";
            pnlChart.BackColor = Color.White; pnlChart.Location = new Point(40, 145); pnlChart.Name = "pnlChart"; pnlChart.Size = new Size(900, 480); pnlChart.Paint += PnlChart_Paint;
            AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; BackColor = Color.WhiteSmoke; ClientSize = new Size(1000, 700); Controls.Add(pnlChart); Controls.Add(lblTotal); Controls.Add(lblTitle); Name = "StatisticsForm"; StartPosition = FormStartPosition.CenterParent; Text = "Question Statistics"; ResumeLayout(false); PerformLayout();
        }
        private Label lblTitle, lblTotal;
        private Panel pnlChart;
    }
}
