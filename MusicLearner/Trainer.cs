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
    delegate string ImageAndSound(char note);

   
    public class Trainer<T> where T:Clef, new()
    {
        public Trainer(StringBuilder dataPath)
        {
            Clef = new T();
            DataPath = dataPath;
            if (!File.Exists(dataPath.ToString()))
            {
                this.SaveUserData(dataPath); 
            }
            Data = this.LoadUserData(dataPath.ToString());
        }

        public UserData userData = new UserData()
        {
            CorrectAnswers = 0,
            Questions = 0,
            BestQueue = 0,
            Queue = 0,
        };
        public List<UserData> Data { get; set; }
        public StringBuilder DataPath { get; set; }

        private Random random = new Random();

        XmlSerializer formatter = new XmlSerializer(typeof(List<UserData>));
        public T Clef { get; }

        public void SaveUserData(StringBuilder dataPath)
        {
            using (var xmlWriter = XmlWriter.Create(dataPath))
            {
                formatter.Serialize(xmlWriter, Data);
                xmlWriter.Close();
            }
        }

        public List<UserData> LoadUserData(string dataPath)
        {
            List<UserData> data;
            using (var xmlReader = XmlReader.Create(dataPath))
            {
                data = (List<UserData>)formatter.Deserialize(xmlReader);
                xmlReader.Close();
            }
            return data;
        }

        public void AddData(UserData newData)
        {
            if (Data.Count == 0)
            {
                Data.Add(newData);
            }
            else
            {
                if (Data.Find(d => d.TestDate == newData.TestDate) != null)
                {
                    UserData oldData = Data.Find(d => d.TestDate == newData.TestDate);
                    oldData.CorrectAnswers += newData.CorrectAnswers;
                    oldData.Questions += newData.Questions;
                    if (oldData.BestQueue < newData.BestQueue)
                    {
                        oldData.BestQueue = newData.BestQueue;
                    }
                }
                else
                {
                    Data.Add(newData);
                }
            }
        }
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

        //public void PlayNote(char note)
        //{
        //    SoundPlayer soundPlayer= new SoundPlayer(Clef.Notes[note].Sound);
        //    soundPlayer.Play();
        //}


    }
}
