using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuestionBankSystem
{
    public partial class StatisticsForm : Form
    {
        private List<Question> questions;

        public StatisticsForm(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
            lblTotal.Text = "Total Questions: " + questions.Count;
        }

        private void PnlChart_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using Font sectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            using Font labelFont = new Font("Segoe UI", 9, FontStyle.Bold);
            using Font valueFont = new Font("Segoe UI", 9, FontStyle.Bold);
            using SolidBrush textBrush = new SolidBrush(Color.Black);
            using SolidBrush easyBrush = new SolidBrush(Color.SteelBlue);
            using SolidBrush mediumBrush = new SolidBrush(Color.DarkOrange);
            using SolidBrush hardBrush = new SolidBrush(Color.SeaGreen);
            using Pen borderPen = new Pen(Color.DarkSlateGray);

            g.DrawString("Questions by Subject and Difficulty", sectionFont, textBrush, 25, 18);

            g.FillRectangle(easyBrush, 475, 22, 12, 12);
            g.DrawString("Easy", labelFont, textBrush, 492, 19);
            g.FillRectangle(mediumBrush, 555, 22, 12, 12);
            g.DrawString("Medium", labelFont, textBrush, 572, 19);
            g.FillRectangle(hardBrush, 655, 22, 12, 12);
            g.DrawString("Hard", labelFont, textBrush, 672, 19);

            List<string> subjects = new List<string>();
            List<int> easyCounts = new List<int>();
            List<int> mediumCounts = new List<int>();
            List<int> hardCounts = new List<int>();

            foreach (Question question in questions)
            {
                int index = subjects.IndexOf(question.Subject);
                if (index == -1)
                {
                    subjects.Add(question.Subject);
                    easyCounts.Add(0);
                    mediumCounts.Add(0);
                    hardCounts.Add(0);
                    index = subjects.Count - 1;
                }

                if (question.Difficulty == "Easy")
                    easyCounts[index]++;
                else if (question.Difficulty == "Medium")
                    mediumCounts[index]++;
                else if (question.Difficulty == "Hard")
                    hardCounts[index]++;
            }

            if (subjects.Count == 0)
            {
                g.DrawString("No questions available.", labelFont, textBrush, 25, 65);
                return;
            }

            int maxCount = 1;
            for (int i = 0; i < subjects.Count; i++)
            {
                if (easyCounts[i] > maxCount)
                    maxCount = easyCounts[i];
                if (mediumCounts[i] > maxCount)
                    maxCount = mediumCounts[i];
                if (hardCounts[i] > maxCount)
                    maxCount = hardCounts[i];
            }

            int rowHeight = Math.Max(95, 390 / subjects.Count);
            int y = 65;

            for (int i = 0; i < subjects.Count; i++)
            {
                g.DrawString(subjects[i], labelFont, textBrush, 25, y);
                int total = easyCounts[i] + mediumCounts[i] + hardCounts[i];
                g.DrawString("Total: " + total, labelFont, textBrush, 820, y);

                int barY = y + 22;
                int[] counts = { easyCounts[i], mediumCounts[i], hardCounts[i] };
                SolidBrush[] brushes = { easyBrush, mediumBrush, hardBrush };
                string[] labels = { "Easy", "Medium", "Hard" };

                for (int j = 0; j < counts.Length; j++)
                {
                    g.DrawString(labels[j], labelFont, textBrush, 25, barY + 1);
                    int barWidth = (int)(650.0 * counts[j] / maxCount);
                    if (barWidth > 0)
                    {
                        g.FillRectangle(brushes[j], 90, barY, barWidth, 18);
                        g.DrawRectangle(borderPen, 90, barY, barWidth, 18);
                    }
                    g.DrawString(counts[j].ToString(), valueFont, textBrush, 750, barY + 1);
                    barY += 22;
                }

                y += rowHeight;
                if (y > pnlChart.Height - 70)
                    break;
            }
        }
    }
}
