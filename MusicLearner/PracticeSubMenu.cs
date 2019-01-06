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
    public partial class PracticeSubMenu : Form
    {
        public PracticeSubMenu(StringBuilder dataPath)
        {
            InitializeComponent();
            DataPath = dataPath;
        }

        public StringBuilder DataPath { get; set; }
        private void trebleClefButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataPath.Append("\\Скрипичный ключ\\" + "UserData.xml");
            PracticeForm<TrebleClef> practiceForm = new PracticeForm<TrebleClef>(DataPath);
            practiceForm.ShowDialog();
            this.Show();
        }

        private void bassClefButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataPath.Append("\\Басовый ключ\\" + "UserData.xml");
            PracticeForm<BassClef> practiceForm = new PracticeForm<BassClef>(DataPath);
            practiceForm.ShowDialog();
            this.Show();
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
