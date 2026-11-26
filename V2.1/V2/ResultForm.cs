using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class ResultForm : Form
    {
        private int score;
        private int total;

        public ResultForm(int score, int total)
        {
            InitializeComponent();
            this.score = score;
            this.total = total;
            double percentage = total == 0 ? 0 : (double)score / total * 100;
            lblScore.Text = "Your Score: " + score + " / " + total;
            lblPercentage.Text = "Percentage: " + percentage.ToString("0") + "%";
            pnlResult.Invalidate();
        }

        private void PnlResult_Paint(object sender, PaintEventArgs e)
        {
            int barWidth = total == 0 ? 0 : (int)(360.0 * score / total);
            e.Graphics.FillRectangle(Brushes.Gainsboro, 20, 25, 360, 32);
            e.Graphics.FillRectangle(Brushes.SeaGreen, 20, 25, barWidth, 32);
            e.Graphics.DrawRectangle(Pens.DarkSlateGray, 20, 25, 360, 32);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
