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
        public PracticeSubMenu(string dataPath)
        {
            InitializeComponent();
            DataPath = dataPath;
        }

        public string DataPath { get; set; }
        private void trebleClefButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PracticeForm practiceForm = new PracticeForm(DataPath,true);
            practiceForm.ShowDialog();
            this.Show();
        }

        private void bassClefButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PracticeForm practiceForm = new PracticeForm(DataPath,false);
            practiceForm.ShowDialog();
            this.Show();
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
