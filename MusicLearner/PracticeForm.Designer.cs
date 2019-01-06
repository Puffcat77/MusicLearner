namespace MusicLearner
{
    partial class PracticeForm<TClef>  where TClef: Clef, new()
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notePictureBox = new System.Windows.Forms.PictureBox();
            this.aButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.finishPracticeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notePictureBox
            // 
            this.notePictureBox.Location = new System.Drawing.Point(48, 42);
            this.notePictureBox.Name = "notePictureBox";
            this.notePictureBox.Size = new System.Drawing.Size(307, 214);
            this.notePictureBox.TabIndex = 0;
            this.notePictureBox.TabStop = false;
            // 
            // aButton
            // 
            this.aButton.Location = new System.Drawing.Point(48, 286);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(80, 68);
            this.aButton.TabIndex = 1;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // bButton
            // 
            this.bButton.Location = new System.Drawing.Point(134, 286);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(80, 68);
            this.bButton.TabIndex = 2;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(220, 286);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(80, 68);
            this.cButton.TabIndex = 3;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(306, 286);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(80, 68);
            this.dButton.TabIndex = 4;
            this.dButton.Text = "D";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // eButton
            // 
            this.eButton.Location = new System.Drawing.Point(392, 286);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(80, 68);
            this.eButton.TabIndex = 5;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(478, 286);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(80, 68);
            this.fButton.TabIndex = 6;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // gButton
            // 
            this.gButton.Location = new System.Drawing.Point(564, 286);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(80, 68);
            this.gButton.TabIndex = 7;
            this.gButton.Text = "G";
            this.gButton.UseVisualStyleBackColor = true;
            this.gButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.Location = new System.Drawing.Point(414, 42);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(205, 81);
            this.checkAnswerButton.TabIndex = 9;
            this.checkAnswerButton.Text = "Проверить ответ";
            this.checkAnswerButton.UseVisualStyleBackColor = true;
            
            // 
            // finishPracticeButton
            // 
            this.finishPracticeButton.Location = new System.Drawing.Point(414, 175);
            this.finishPracticeButton.Name = "finishPracticeButton";
            this.finishPracticeButton.Size = new System.Drawing.Size(205, 81);
            this.finishPracticeButton.TabIndex = 11;
            this.finishPracticeButton.Text = "Завершить практику";
            this.finishPracticeButton.UseVisualStyleBackColor = true;
            this.finishPracticeButton.Click += new System.EventHandler(this.finishPracticeButton_Click);
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 399);
            this.Controls.Add(this.finishPracticeButton);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.gButton);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.notePictureBox);
            this.Name = "PracticeForm";
            this.Text = "Режим практики";
            ((System.ComponentModel.ISupportInitialize)(this.notePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox notePictureBox;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.Button checkAnswerButton;
        private System.Windows.Forms.Button finishPracticeButton;
    }
}