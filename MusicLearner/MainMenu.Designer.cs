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
            this.theoryButton = new System.Windows.Forms.Button();
            this.practiceButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.programInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(69, 274);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(171, 49);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // theoryButton
            // 
            this.theoryButton.Location = new System.Drawing.Point(69, 109);
            this.theoryButton.Name = "theoryButton";
            this.theoryButton.Size = new System.Drawing.Size(171, 49);
            this.theoryButton.TabIndex = 1;
            this.theoryButton.Text = "Теоретические сведения";
            this.theoryButton.UseVisualStyleBackColor = true;
            this.theoryButton.Click += new System.EventHandler(this.theoryButton_Click);
            // 
            // practiceButton
            // 
            this.practiceButton.Location = new System.Drawing.Point(69, 164);
            this.practiceButton.Name = "practiceButton";
            this.practiceButton.Size = new System.Drawing.Size(171, 49);
            this.practiceButton.TabIndex = 2;
            this.practiceButton.Text = "Практические упражнения";
            this.practiceButton.UseVisualStyleBackColor = true;
            this.practiceButton.Click += new System.EventHandler(this.practiceButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(69, 54);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(171, 49);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "Пользователь";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // programInfoButton
            // 
            this.programInfoButton.Location = new System.Drawing.Point(69, 219);
            this.programInfoButton.Name = "programInfoButton";
            this.programInfoButton.Size = new System.Drawing.Size(171, 49);
            this.programInfoButton.TabIndex = 4;
            this.programInfoButton.Text = "О программе";
            this.programInfoButton.UseVisualStyleBackColor = true;
            this.programInfoButton.Click += new System.EventHandler(this.programInfoButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(319, 384);
            this.Controls.Add(this.programInfoButton);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.practiceButton);
            this.Controls.Add(this.theoryButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "MainMenu";
            this.Text = "Music Learner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button theoryButton;
        private System.Windows.Forms.Button practiceButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button programInfoButton;
    }
}

