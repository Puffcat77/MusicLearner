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
            Trainer = new Trainer<TClef>();
            
            Trainer.OnNoteGenerated += OnNoteGenerated;
            Trainer.OnAnswerApplied += OnAnswerApplied;
            Trainer.StartTrain();
            for (int i = 0; i < Trainer.Clef.Notes.Count; i++)
            {
                Buttons[i].Text = Trainer.Clef[i].Symbol.ToString();
                Buttons[i].Tag = Trainer.Clef[i];
            }
        }

        private void OnNoteGenerated(object sender, NoteEventArgs e)
        {
            notePictureBox.ImageLocation = e.Note.Image;
        }


        public Button[] Buttons { get; set; }
        public Trainer<TClef> Trainer { get; set; }
       
        UserProgress data = new UserProgress();


        private void noteButton_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);
            Trainer.ApplyAnswer(button.Tag as Note);
        }

        private void OnAnswerApplied(object sender, NoteEventArgs e)
        {
            if (e.IsNotValid)
            {
                MessageBox.Show("Ответ правильный.");
            }
            else
            {
                MessageBox.Show("Ответ неверный. Правильный ответ - нота " + Trainer.CurrentNote.Symbol);
            }
            //Trainer.userData.Questions++;
            Trainer.GenerateNote();
        }


        private void finishPracticeButton_Click(object sender, EventArgs e)
        {
            //Trainer.userData.Questions--;
            //Trainer.AddData(Trainer.userData);
            //Trainer.SaveUserData(Trainer.DataPath);
            this.Close();
        }
    }
}
