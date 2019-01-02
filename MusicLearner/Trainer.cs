using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MusicLearner
{
    delegate string ImageAndSound(char note);

   
    public class Trainer<T> where T:Clef, new()
    {
        public Trainer()
        {
            //if (key)
            //{
            //    MusicTrainer = new TrebleClef();
            //}
            //else
            //{
            //    MusicTrainer = new BassClef();
            //}
            //correctNote = GetNoteToTrain();
            //ImageAndSound del = GetNoteImage;

            Clef = new T();
            correctNote = GetNoteToTrain();
        }


        private Random random = new Random();
        public T Clef { get; }
        //private char[] noteNumber = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        private char correctNote;

        public char GetNoteToTrain()
        {
            int note = random.Next(0,6);
            return Clef.Notes
                .Select(n => n.Key)
                .ToArray()[note];
            //return noteNumber[note];
        }

        //public event NoteToTrainIsGotten()
        public string GetNoteImage(char note)
        {
            return Clef.Notes[note].Image;
        }

        public void PlayNote(char note)
        {
            SoundPlayer soundPlayer= new SoundPlayer(Clef.Notes[note].Sound);
            soundPlayer.Play();
        }
    }
}
