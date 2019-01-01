﻿using System;
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
            if (Users.Capacity==0)
            {
                chooseUserButton.Enabled = false;
                changeUserDataButton.Enabled = false;
                deleteUserButton.Enabled = false;
                MessageBox.Show("Список пользователей пуст.\n" +
                    "Для работы создайте пользователя.");
            }
        }

        UserStorage userStorage = new UserStorage();
        public List<User> Users { get; set; }
        public User сurrentUser = new User();
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
                    "\n Числовой идентификатор - число от -2147483648 до 2147483647.");
                return;
            }
            if (userStorage.UserExists(user))
            {
                MessageBox.Show("Данный пользователь уже существует в списке пользователей.");
            }
            else
            {
                Users=userStorage.AddUser(user);
                userStorage.SaveUsers(Users);
                chooseUserButton.Enabled = true;
                changeUserDataButton.Enabled = true;
                deleteUserButton.Enabled = true;
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
                    "\n Числовой идентификатор - должен быть числом от -2147483648 до 2147483647.");
                return;
            }
            if (!userStorage.UserExists(user))
            {
                MessageBox.Show("Пользователь не существует в списке пользователей.");
            }
            else
            {
                Users=userStorage.DeleteUser(user);
                userStorage.SaveUsers(Users);
                MessageBox.Show("Пользователь удален.");
            }
            if (Users.Capacity == 0)
            {
                chooseUserButton.Enabled = false;
                changeUserDataButton.Enabled = false;
                deleteUserButton.Enabled = false;
                MessageBox.Show("Список пользователей пуст.\n" +
                    "Для работы создайте пользователя.");
            }
        }

        private void chooseUserButton_Click(object sender, EventArgs e)
        {
            сurrentUser.Id = int.Parse(idTextBox.Text) ;
            if (userStorage.UserExists(сurrentUser))
            {
                сurrentUser = userStorage.ChooseUser(сurrentUser.Id);
                firstNameTextBox.Text = сurrentUser.FirstName;
                lastNameTextBox.Text = сurrentUser.LastName;
                idTextBox.Text = сurrentUser.Id.ToString();
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
            if (userStorage.UserExists(user))
            {
                Users = userStorage.ChangeUserData(user);
                userStorage.SaveUsers(Users);
                MessageBox.Show("Данные о пользователе с данным идентификатором изменены.");
            }
            else
            {
                MessageBox.Show("Данный пользователь не содержится в базе пользователей.");
            }
        }
        private void finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
