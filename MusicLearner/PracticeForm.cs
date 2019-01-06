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
    public partial class PracticeForm<TClef> : Form where TClef : Clef, new()
    {
        public PracticeForm(string dataPath)
        {
            InitializeComponent();
            DataPath = dataPath;
            Buttons = new Button[] { aButton, bButton, cButton, dButton, eButton, fButton, gButton };
            Trainer = new Trainer<TClef>();
            CurrentNote = Trainer.GetNoteToTrain();
            notePictureBox.ImageLocation = Trainer.GetNoteImage(CurrentNote);
            var notesSigns = Trainer.Clef.Notes.Select((n)=> n.Key).ToList();
            for (int i = 0; i < notesSigns.Count; i++)
            {
                Buttons[i].Text = notesSigns[i].ToString();
                Buttons[i].Tag = notesSigns[i];
            }
            
        }

        
        public Button[] Buttons { get; set; }
        public string DataPath { get; set; }
        public Trainer<TClef> Trainer { get; set; }
        internal char CurrentNote { get; set; }
        internal char ChosenNote { get; set; }
        private void notePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);

            ChosenNote = (char)button.Tag;
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
