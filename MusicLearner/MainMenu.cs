using System;
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
                practiceButton.Enabled = false;
                userStatisticButton.Enabled = false;
                MessageBox.Show("Для доступа к практике и статистике выберите или создайте пользователя.");
            }
        }

        public User User { get; set; }
        public StringBuilder dataPath = new StringBuilder(Directory.GetCurrentDirectory());

        private void userButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            if (userForm.currentUser != null)
            {
                User = userForm.currentUser;
                practiceButton.Enabled = true;
                userStatisticButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Пользователь не выбран." +
                    "\nДоступ к практике закрыт.");
            }
            if (User == null)
            {
                practiceButton.Enabled = false;
                userStatisticButton.Enabled = false;
                MessageBox.Show("Для доступа к практике и статистике выберите или создайте пользователя.");
            }
            this.Show();
        }
        private void theoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteTheoryForm noteTheoryForm = new NoteTheoryForm();
            noteTheoryForm.ShowDialog();
            this.Show();
        }
        
        private void practiceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataPath.Append("\\" + User.FirstName + " " + User.LastName);
            PracticeSubMenu subMenu = new PracticeSubMenu(User);
            subMenu.ShowDialog();
            this.Show();
        }

        private void programInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgramInfoForm programInfoForm = new ProgramInfoForm();
            programInfoForm.ShowDialog();
            this.Show();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userStatisticButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatisticForm statistic = new StatisticForm(new UserProgressStorage(User));
            statistic.ShowDialog();
            this.Show();
        }
    }
}
