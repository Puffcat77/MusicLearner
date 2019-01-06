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
        //public void SaveUserData(StringBuilder dataPath)
        //{
        //    using (var xmlWriter = XmlWriter.Create(dataPath))
        //    {
        //        formatter.Serialize(xmlWriter, Data);
        //        xmlWriter.Close();
        //    }
        //}

        //public List<UserData> LoadUserData(string dataPath)
        //{
        //    List<UserData> data;
        //    using (var xmlReader = XmlReader.Create(dataPath))
        //    {
        //        data = (List<UserData>)formatter.Deserialize(xmlReader);
        //        xmlReader.Close();
        //    }
        //    return data;
        //}

        //public void AddData(UserData newData)
        //{
        //    if (Data.Count == 0)
        //    {
        //        Data.Add(newData);
        //    }
        //    else
        //    {
        //        if (Data.Find(d => d.TestDate == newData.TestDate) != null)
        //        {
        //            UserData oldData = Data.Find(d => d.TestDate == newData.TestDate);
        //            oldData.CorrectAnswers += newData.CorrectAnswers;
        //            oldData.Questions += newData.Questions;
        //            if (oldData.BestQueue < newData.BestQueue)
        //            {
        //                oldData.BestQueue = newData.BestQueue;
        //            }
        //        }
        //        else
        //        {
        //            Data.Add(newData);
        //        }
        //    }
        //}
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
