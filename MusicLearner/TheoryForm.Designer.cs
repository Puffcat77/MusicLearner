namespace MusicLearner
{
    partial class TheoryForm
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
            this.previousButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.toMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(58, 572);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(173, 89);
            this.previousButton.TabIndex = 0;
            this.previousButton.Text = "Предыдущее";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(280, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 272);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(58, 316);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(753, 234);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(638, 572);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(173, 89);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Следующее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // toMainMenu
            // 
            this.toMainMenu.Location = new System.Drawing.Point(348, 572);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(173, 89);
            this.toMainMenu.TabIndex = 3;
            this.toMainMenu.Text = "Вернуться в главное меню";
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 684);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Name = "TheoryForm";
            this.Text = "Теоретические сведения";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button toMainMenu;
    }
}