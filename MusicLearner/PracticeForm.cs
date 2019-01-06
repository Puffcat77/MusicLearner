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
        public PracticeForm(StringBuilder dataPath)
        {
            InitializeComponent();
            Buttons = new Button[] { aButton, bButton, cButton, dButton, eButton, fButton, gButton };
            Trainer = new Trainer<TClef>(dataPath);
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
        public Trainer<TClef> Trainer { get; set; }
        internal char CurrentNote { get; set; }
        internal char ChosenNote { get; set; }
        UserData data = new UserData();
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
                Trainer.userData.CorrectAnswers++;
                Trainer.userData.Queue++;
                MessageBox.Show("Ответ правильный.");
            }
            else
            {
                if (Trainer.userData.BestQueue < Trainer.userData.Queue)
                {
                    Trainer.userData.BestQueue = Trainer.userData.Queue;
                }
                Trainer.userData.Queue = 0;
                MessageBox.Show("Ответ неверный. Правильный ответ - нота "+CurrentNote);
            }
            Trainer.userData.Questions++;
            CurrentNote = Trainer.GetNoteToTrain();
            notePictureBox.ImageLocation = Trainer.GetNoteImage(CurrentNote);
        }

        private void finishPracticeButton_Click(object sender, EventArgs e)
        {
            //Trainer.userData.Questions--;
            Trainer.AddData(Trainer.userData);
            Trainer.SaveUserData(Trainer.DataPath);
            this.Close();
        }
    }
}
