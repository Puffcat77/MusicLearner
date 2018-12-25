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
            //XDocument xDoc = new XDocument();
            //XElement Users = new XElement("users");
            //XElement zeroUser = new XElement("defaultuser");
            //XAttribute userFirstName = new XAttribute("FirstName","");
            //XAttribute userLastName = new XAttribute("LastName", "");
            //XAttribute userId = new XAttribute("Id", "");
            //zeroUser.Add(userFirstName);
            //zeroUser.Add(userLastName);
            //zeroUser.Add(userId);
            //Users.Add(zeroUser);
            //xDoc.Add(Users);
            //xDoc.Save("users.xml");
            this.SaveUsers(users);
            users = this.LoadUsers();
        }

        XmlSerializer formatter = new XmlSerializer(typeof(User[]));
        List<User> users = new List<User>();
        public void SaveUsers(List<User> users)
        {
            using (var xmlWriter = XmlWriter.Create("users.xml"))
            {
                formatter.Serialize(xmlWriter, users.ToArray());
                xmlWriter.Close();
                this.users = users.ToList();
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
            user.Id = users.Count + 1;
            users.Add(user);
            return users;
        }

        public List<User> DeleteUser (User user, List<User> users)
        {
            List<User> newUsers = users;
            newUsers.Remove(user);
            return newUsers;
        }
    }
}
