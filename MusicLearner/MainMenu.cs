﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicLearner
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            if (User == null)
            {
                theoryButton.Enabled = false;
                practiceButton.Enabled = false;
                MessageBox.Show("Для доступа к теории и практике выберите или создайте пользователя.");
            }
        }

        public User User { get; set; }
        public StringBuilder dataPath = new StringBuilder(Directory.GetCurrentDirectory());

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void practiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataPath.Append("\\" + User.FirstName + " " + User.LastName);
            PracticeSubMenu subMenu = new PracticeSubMenu(User);
            subMenu.ShowDialog();
            this.Show();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            if (userForm.currentUser != null)
            {
                User = userForm.currentUser;
                theoryButton.Enabled = true;
                practiceButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Пользователь не выбран." +
                    "\nДоступ к теории и практике закрыт.");
            }
            if (User == null)
            {
                theoryButton.Enabled = false;
                practiceButton.Enabled = false;
                MessageBox.Show("Для доступа к теории и практике выберите или создайте пользователя.");
            }
            this.Show();
        }

        private void programInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgramInfoForm programInfoForm = new ProgramInfoForm();
            programInfoForm.ShowDialog();
            this.Show();
        }
    }
}
