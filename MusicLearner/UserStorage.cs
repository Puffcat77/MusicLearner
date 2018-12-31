using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace MusicLearner
{
    public class UserStorage
    {
        public UserStorage()
        {
            users = this.LoadUsers();
        }

        XmlSerializer formatter = new XmlSerializer(typeof(List<User>));
        List<User> users = new List<User>();
        public void SaveUsers(List<User> users)
        {
            using (var xmlWriter = XmlWriter.Create("users.xml"))
            {
                formatter.Serialize(xmlWriter, users);
                xmlWriter.Close();
            }
        }

        public List<User> LoadUsers()
        {
            using (var xmlReader = XmlReader.Create("users.xml"))
            {
                users = (List<User>)formatter.Deserialize(xmlReader);
                xmlReader.Close();
            }
            return users;
        }

        public bool UserExists(User user, List<User> users)
        {
            if (!users.Any())
            {
                users = LoadUsers();
            }
            return users.Any((u) => user.Id == u.Id);
        }

        public List<User> AddUser(User user,List<User> users)
        {
            users.Add(user);
            return users;
        }

        public List<User> DeleteUser (User user, List<User> users)
        {
            List<User> newUsers = users;
            newUsers.Remove(users.Find((u)=> user.Id==u.Id));
            return newUsers;
        }

        public User ChooseUser(int userId, List<User> users)
        {
            User user = new User();
            user = users.Find((u)=>u.Id==userId);
            return user;
        }

        public List<User> ChangeUserData(User newUser, List<User> users)
        {
            int userNumber = users.FindIndex((u) => u.Id == newUser.Id);
            users[userNumber].FirstName = newUser.FirstName;
            users[userNumber].LastName = newUser.LastName;
            return users;
        }

        public User GetUser(User user)
        {
            return user;
        }
    }
}
