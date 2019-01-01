using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MusicLearner
{
    delegate string ImageAndSound(char note);
    class Trainer<T> where T:Clef, new()
    {
        public Trainer(bool key)
        {
            if (key)
            {
                MusicTrainer = new TrebleClef();
            }
            else
            {
                MusicTrainer = new BassClef();
            }
            
            correctNote = GetNoteToTrain();
            ImageAndSound del = GetNoteImage;
        }



        private Clef MusicTrainer { get; set; }
        private char[] noteNumber = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        private char chosenNote;
        private char correctNote;

        public char GetNoteToTrain()
        {
            return noteNumber[new Random(6).Next(6)];
        }

        //public event NoteToTrainIsGotten()
        public string GetNoteImage(char note)
        {
            return MusicTrainer.Notes[note].Image;
        }

        public void PlayNote(char note)
        {
            SoundPlayer soundPlayer= new SoundPlayer(MusicTrainer.Notes[note].Sound);
            soundPlayer.Play();
        }
    }
}
