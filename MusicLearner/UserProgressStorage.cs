using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MusicLearner
{
    public class UserProgressStorage
    {
        private User user;
        private List<UserProgress> userProgress = new List<UserProgress>();
        XmlSerializer formatter = new XmlSerializer(typeof(List<UserProgress>));
        private string userProgressPath = string.Empty;
        public UserProgressStorage(User user,string clefType)
        {
            this.user = user;
            userProgressPath = $@"UserData\{user.FirstName} {user.LastName}\{clefType}\progress.xml";
            if (!File.Exists(userProgressPath))
            {
                SaveProgress();
            }
            else
            {
                userProgress = LoadProgress();
            }
        }

        public List<UserProgress> LoadProgress()
        {

                using (var xmlReader = XmlReader.Create(userProgressPath))
                {
                    userProgress = (List<UserProgress>)formatter.Deserialize(xmlReader);
                    xmlReader.Close();
                }

            return userProgress;
        }

        public void SaveProgress()
        {
            using (var xmlWriter = XmlWriter.Create(userProgressPath))
            {
                formatter.Serialize(xmlWriter, userProgress);
                xmlWriter.Close();
            }
        }

        public void AddUserProgress(UserProgress progress)
        {
            var entry =  userProgress.FirstOrDefault(up => up.TestDate == progress.TestDate);
            if (entry != null)
            {
                entry = progress;
            }
            userProgress.Add(progress);
        }
    }
}
