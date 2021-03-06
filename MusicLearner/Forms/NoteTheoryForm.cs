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
    public partial class NoteTheoryForm:Form
    {
        public NoteTheoryForm()
        {
            InitializeComponent();
            Buttons = new Button[] { aButton, bButton, cButton, dButton, eButton, fButton, gButton };
            Theory = new Theory();
        }

        public Theory Theory { get; set; }
        public Button[] Buttons { get; set; }
        private void noteButton_Click(object sender, EventArgs e)
        {
            var note = (char)(sender as Button).Tag;
            string[] paths = Theory.GetNoteImages(note);
            bassPictureBox.ImageLocation = paths[0];
            bassTextBox.Text = note + " в басовом ключе";
            keyboardPictureBox.ImageLocation = paths[1];
            keyboardTextBox.Text = note + " на клавиатуре";
            treblePictureBox.ImageLocation = paths[2];
            trebleTextBox.Text = note + " в скрипичном ключе";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
