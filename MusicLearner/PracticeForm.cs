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
        public PracticeForm(string dataPath, bool key)
        {
            InitializeComponent();
            DataPath = dataPath;
            Buttons = new Button[] { aButton, bButton, cButton, dButton, eButton, fButton, gButton };
            Trainer = new Trainer<Clef>(key);
            CurrentNote = Trainer.GetNoteToTrain();
            notePictureBox.ImageLocation = Trainer.GetNoteImage(CurrentNote);
        }

        
        public Button[] Buttons { get; set; }
        public string DataPath { get; set; }
        public Trainer<Clef> Trainer { get; set; }
        internal char CurrentNote { get; set; }
        internal char ChosenNote { get; set; }
        private void notePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void aButtton_Click(object sender, EventArgs e)
        {
            ChosenNote = 'A';
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            ChosenNote = 'B';
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            ChosenNote = 'C';
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            ChosenNote = 'D';
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            ChosenNote = 'E';
        }

        private void fButton_Click(object sender, EventArgs e)
        {
            ChosenNote = 'F';
        }

        private void gButton_Click(object sender, EventArgs e)
        {
            ChosenNote = 'G';
        }

        private void checkAnswerButton_Click(object sender, EventArgs e)
        {
            if (ChosenNote == CurrentNote)
            {
                MessageBox.Show("Ответ правильный.");
            }
            else
            {
                MessageBox.Show("Ответ неверный. Правильный ответ - нота "+CurrentNote);
            }
            CurrentNote = Trainer.GetNoteToTrain();
            notePictureBox.ImageLocation = Trainer.GetNoteImage(CurrentNote);
        }

        private void finishPracticeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
