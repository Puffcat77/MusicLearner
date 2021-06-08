using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace MusicLearner
{
    public class Trainer<T> where T:Clef, new()
    {
        public Trainer()
        {
            Clef = new T();
        }

        private Random random = new Random();
        public Note CurrentNote { get; set; }
        public T Clef { get; }
        public int TotalQuestions { get; private set; }
        public int CorrectAnswers { get; private set; }
        public int BestQueue { get; private set; }
        private int currentSuccessQueue = 0;
        
        public Note GenerateNote()
        {
            int noteIndex = random.Next(0,6);

            CurrentNote = Clef.Notes[noteIndex];
            OnNoteGenerated?.Invoke(this, new NoteEventArgs() { Note = CurrentNote });
            return CurrentNote;
        }

        public void ApplyAnswer(Note note)
        {
            TotalQuestions += 1;
            var isNoteValid = note == CurrentNote;
            if (isNoteValid)
            {
                currentSuccessQueue += 1;
                CorrectAnswers += 1;
            }
            else
            {   
                BestQueue = BestQueue > currentSuccessQueue
                            ? BestQueue
                            : currentSuccessQueue;
                currentSuccessQueue = 0;
            }
            if (CorrectAnswers == TotalQuestions)
            {
                BestQueue = CorrectAnswers;
            }
            OnAnswerApplied?.Invoke(this, new NoteEventArgs() { Note = note, IsNotValid = isNoteValid });
        }


        public void StartTrain()
        {
            GenerateNote();
        }

        public event EventHandler<NoteEventArgs> OnNoteGenerated;

        public event EventHandler<NoteEventArgs> OnAnswerApplied;

    }
}
