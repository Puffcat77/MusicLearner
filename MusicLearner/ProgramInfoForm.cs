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
    public partial class ProgramInfoForm : Form
    {
        public ProgramInfoForm()
        {
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
