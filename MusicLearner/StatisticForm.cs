using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLearner
{
    public partial class StatisticForm : Form
    {
        public StatisticForm(UserProgressStorage storage)
        {
            InitializeComponent();
            Progress = storage.LoadProgress();
            foreach (var item in Progress)
            {
                var correctAnswersPercent = ((float)item.CorrectAnswers / (float)item.Questions * 100) / 1;
                statisticChart.Series["Общее число вопросов"].Points.AddXY(item.TestDate.Day, item.Questions);
                statisticChart.Series["Лучшая серия ответов"].Points.AddXY(item.TestDate.Day, item.BestQueue);
                statisticChart.Series["Процент правильных ответов"].Points.AddXY(item.TestDate.Day, correctAnswersPercent);
            }
        }

        public List<UserProgress> Progress { get; set; }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
