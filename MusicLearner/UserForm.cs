using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MusicLearner
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            Users = userStorage.LoadUsers();
        }

        UserStorage userStorage = new UserStorage();
        User user = new User();
        public List<User> Users { get; set; }
        private void saveUserButton_Click(object sender, EventArgs e)
        {
            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            try
            {
                user.Id = int.Parse(idTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели неверный числовой идентификатор." +
                    "/n Числовой идентификатор - число от -2147483648 до 2147483647.");
            }
            if (userStorage.UserExists(user, Users))
            {
                MessageBox.Show("Данный пользователь уже существует в списке пользователей.");
            }
            else
            {
                userStorage.AddUser(user, Users);
                userStorage.SaveUsers(Users);
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            try
            {
                user.Id = int.Parse(idTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели неверный числовой идентификатор." +
                    "/n Числовой идентификатор - должен быть числом от -2147483648 до 2147483647.");
            }
            if (userStorage.UserExists(user, Users))
            {
                MessageBox.Show("Данный пользователь не существует в списке пользователей.");
            }
            else
            {
                userStorage.DeleteUser(user, Users);
                userStorage.SaveUsers(Users);
            }
        }
    }
}
