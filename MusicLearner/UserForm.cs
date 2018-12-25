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
        public List<User> Users { get; set; }
        private void saveUserButton_Click(object sender, EventArgs e)
        {
            User user = new User();
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
                return;
            }
            if (userStorage.UserExists(user, Users))
            {
                MessageBox.Show("Данный пользователь уже существует в списке пользователей.");
            }
            else
            {
                Users=userStorage.AddUser(user, Users);
                userStorage.SaveUsers(Users);
                MessageBox.Show("Пользователь добавлен.");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            try
            {
                user.Id = int.Parse(idTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный числовой идентификатор." +
                    "/n Числовой идентификатор - должен быть числом от -2147483648 до 2147483647.");
                return;
            }
            if (!userStorage.UserExists(user, Users))
            {
                MessageBox.Show("Пользователь не существует в списке пользователей.");
            }
            else
            {
                Users=userStorage.DeleteUser(user, Users);
                userStorage.SaveUsers(Users);
                MessageBox.Show("Пользователь удален.");
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chooseUserButton_Click(object sender, EventArgs e)
        {
            User user = new User { Id = int.Parse(idTextBox.Text) };
            if (userStorage.UserExists(user, Users))
            {
                user = userStorage.ChooseUser(user.Id, Users);
                firstNameTextBox.Text = user.FirstName;
                lastNameTextBox.Text = user.LastName;
                idTextBox.Text = user.Id.ToString();
                MessageBox.Show("Пользователь по данному идентификатору выбран.");
            }
            else
            {
                MessageBox.Show("Данный пользователь не содержится в базе пользователей.");
            }
        }

        private void changeUserDataButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Id = int.Parse(idTextBox.Text)
            };
            if (userStorage.UserExists(user, Users))
            {
                Users = userStorage.ChangeUserData(user, Users);
                userStorage.SaveUsers(Users);
                MessageBox.Show("Данные о пользователе с данным идентификатором изменены.");
            }
            else
            {
                MessageBox.Show("Данный пользователь не содержится в базе пользователей.");
            }
        }
    }
}
