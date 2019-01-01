namespace MusicLearner
{
    partial class PracticeForm
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
            this.components = new System.ComponentModel.Container();
            this.notePictureBox = new System.Windows.Forms.PictureBox();
            this.aButtton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.gButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.notePictureBox.Click += new System.EventHandler(this.notePictureBox_Click);
            // 
            // aButtton
            // 
            this.aButtton.Location = new System.Drawing.Point(48, 286);
            this.aButtton.Name = "aButtton";
            this.aButtton.Size = new System.Drawing.Size(80, 68);
            this.aButtton.TabIndex = 1;
            this.aButtton.Text = "A";
            this.aButtton.UseVisualStyleBackColor = true;
            // 
            // bButton
            // 
            this.bButton.Location = new System.Drawing.Point(134, 286);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(80, 68);
            this.bButton.TabIndex = 2;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(220, 286);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(80, 68);
            this.cButton.TabIndex = 3;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            // 
            // dButton
            // 
            this.dButton.Location = new System.Drawing.Point(306, 286);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(80, 68);
            this.dButton.TabIndex = 4;
            this.dButton.Text = "D";
            this.dButton.UseVisualStyleBackColor = true;
            // 
            // eButton
            // 
            this.eButton.Location = new System.Drawing.Point(392, 286);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(80, 68);
            this.eButton.TabIndex = 5;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = true;
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(478, 286);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(80, 68);
            this.fButton.TabIndex = 6;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            // 
            // gButton
            // 
            this.gButton.Location = new System.Drawing.Point(564, 286);
            this.gButton.Name = "gButton";
            this.gButton.Size = new System.Drawing.Size(80, 68);
            this.gButton.TabIndex = 7;
            this.gButton.Text = "G";
            this.gButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 367);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(596, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Проверить ответ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 57);
            this.button2.TabIndex = 10;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 57);
            this.button3.TabIndex = 11;
            this.button3.Text = "Завершить тестирование";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 399);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gButton);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.aButtton);
            this.Controls.Add(this.notePictureBox);
            this.Name = "PracticeForm";
            this.Text = "PracticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.notePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox notePictureBox;
        private System.Windows.Forms.Button aButtton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button gButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}