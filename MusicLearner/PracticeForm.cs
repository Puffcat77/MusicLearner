using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicLearner
{
    public partial class PracticeForm : Form
    {
        public PracticeForm(User user)
        {
            InitializeComponent();
            DataPath = Directory.GetCurrentDirectory() + "\\" + user.FirstName + " " + user.LastName;

            Clef =;
        }

        Trainer<TrebleClef> trainer = new Trainer<TrebleClef>(Clef);
        string DataPath { get; set; }
        bool Clef { get; set; }
        private void notePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
