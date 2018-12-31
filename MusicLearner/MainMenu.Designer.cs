namespace MusicLearner
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.TheoryButton = new System.Windows.Forms.Button();
            this.PracticeButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(288, 318);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(191, 87);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TheoryButton
            // 
            this.TheoryButton.Location = new System.Drawing.Point(288, 132);
            this.TheoryButton.Name = "TheoryButton";
            this.TheoryButton.Size = new System.Drawing.Size(191, 87);
            this.TheoryButton.TabIndex = 1;
            this.TheoryButton.Text = "Теоретические сведения";
            this.TheoryButton.UseVisualStyleBackColor = true;
            // 
            // PracticeButton
            // 
            this.PracticeButton.Location = new System.Drawing.Point(288, 225);
            this.PracticeButton.Name = "PracticeButton";
            this.PracticeButton.Size = new System.Drawing.Size(191, 87);
            this.PracticeButton.TabIndex = 2;
            this.PracticeButton.Text = "Практические упражнения";
            this.PracticeButton.UseVisualStyleBackColor = true;
            this.PracticeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(288, 39);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(191, 87);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "Пользователь";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.PracticeButton);
            this.Controls.Add(this.TheoryButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "Form1";
            this.Text = "Music Learner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button TheoryButton;
        private System.Windows.Forms.Button PracticeButton;
        private System.Windows.Forms.Button userButton;
    }
}

