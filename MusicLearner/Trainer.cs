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
            Clef = new T();
            correctNote = GetNoteToTrain();
        }


        private Random random = new Random();
        public T Clef { get; }
        private char correctNote;
        //private int 

        public char GetNoteToTrain()
        {
            int note = random.Next(0,6);
            return Clef.Notes
                .Select(n => n.Key)
                .ToArray()[note];
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

        public void SaveUserData()
        {

        }
    }
}
