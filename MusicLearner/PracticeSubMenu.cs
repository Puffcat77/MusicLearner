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
        public PracticeSubMenu(User user)
        {
            InitializeComponent();
            User = user;
        }

        public User User { get; set; }
        private void trebleClefButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PracticeForm<TrebleClef> practiceForm = new PracticeForm<TrebleClef>(User);
            practiceForm.ShowDialog();
            this.Show();
        }

        private void bassClefButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PracticeForm<BassClef> practiceForm = new PracticeForm<BassClef>(User);
            practiceForm.ShowDialog();
            this.Show();
        }

        private void toMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
