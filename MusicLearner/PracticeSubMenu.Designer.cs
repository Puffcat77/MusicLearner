namespace MusicLearner
{
    partial class PracticeSubMenu
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
            this.trebleClefButton = new System.Windows.Forms.Button();
            this.bassClefButton = new System.Windows.Forms.Button();
            this.toMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trebleClefButton
            // 
            this.trebleClefButton.Location = new System.Drawing.Point(47, 23);
            this.trebleClefButton.Name = "trebleClefButton";
            this.trebleClefButton.Size = new System.Drawing.Size(117, 84);
            this.trebleClefButton.TabIndex = 0;
            this.trebleClefButton.Text = "Скрипичный ключ";
            this.trebleClefButton.UseVisualStyleBackColor = true;
            this.trebleClefButton.Click += new System.EventHandler(this.trebleClefButton_Click);
            // 
            // bassClefButton
            // 
            this.bassClefButton.Location = new System.Drawing.Point(170, 23);
            this.bassClefButton.Name = "bassClefButton";
            this.bassClefButton.Size = new System.Drawing.Size(117, 84);
            this.bassClefButton.TabIndex = 0;
            this.bassClefButton.Text = "Басовый ключ";
            this.bassClefButton.UseVisualStyleBackColor = true;
            this.bassClefButton.Click += new System.EventHandler(this.bassClefButton_Click);
            // 
            // toMainMenuButton
            // 
            this.toMainMenuButton.Location = new System.Drawing.Point(111, 113);
            this.toMainMenuButton.Name = "toMainMenuButton";
            this.toMainMenuButton.Size = new System.Drawing.Size(117, 84);
            this.toMainMenuButton.TabIndex = 1;
            this.toMainMenuButton.Text = "Вернуться в главное меню";
            this.toMainMenuButton.UseVisualStyleBackColor = true;
            this.toMainMenuButton.Click += new System.EventHandler(this.toMainMenuButton_Click);
            // 
            // PracticeSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 232);
            this.Controls.Add(this.toMainMenuButton);
            this.Controls.Add(this.bassClefButton);
            this.Controls.Add(this.trebleClefButton);
            this.Name = "PracticeSubMenu";
            this.Text = "Выбор ключа";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trebleClefButton;
        private System.Windows.Forms.Button bassClefButton;
        private System.Windows.Forms.Button toMainMenuButton;
    }
}