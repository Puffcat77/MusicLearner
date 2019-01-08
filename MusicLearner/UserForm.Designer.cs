namespace MusicLearner
{
    partial class UserForm
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
            this.saveUserButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.chooseUserButton = new System.Windows.Forms.Button();
            this.changeUserDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(122, 118);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(170, 58);
            this.saveUserButton.TabIndex = 3;
            this.saveUserButton.Text = "Сохранить пользователя";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.AccessibleDescription = "Имя";
            this.firstNameTextBox.Location = new System.Drawing.Point(34, 40);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Text = "Имя";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lastNameTextBox.Location = new System.Drawing.Point(210, 40);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Text = "Фамилия";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(298, 182);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(170, 58);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "Удалить пользователя";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idTextBox.Location = new System.Drawing.Point(386, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(170, 20);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Text = "Идентификатор";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(210, 246);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(170, 58);
            this.finishButton.TabIndex = 5;
            this.finishButton.Text = "Завершить работу с пользователями";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // chooseUserButton
            // 
            this.chooseUserButton.Location = new System.Drawing.Point(298, 118);
            this.chooseUserButton.Name = "chooseUserButton";
            this.chooseUserButton.Size = new System.Drawing.Size(170, 58);
            this.chooseUserButton.TabIndex = 6;
            this.chooseUserButton.Text = "Найти и выбрать пользователя по числовому идентификатору";
            this.chooseUserButton.UseVisualStyleBackColor = true;
            this.chooseUserButton.Click += new System.EventHandler(this.chooseUserButton_Click);
            // 
            // changeUserDataButton
            // 
            this.changeUserDataButton.Location = new System.Drawing.Point(122, 182);
            this.changeUserDataButton.Name = "changeUserDataButton";
            this.changeUserDataButton.Size = new System.Drawing.Size(170, 58);
            this.changeUserDataButton.TabIndex = 7;
            this.changeUserDataButton.Text = "Изменить данные о пользователе";
            this.changeUserDataButton.UseVisualStyleBackColor = true;
            this.changeUserDataButton.Click += new System.EventHandler(this.changeUserDataButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 351);
            this.Controls.Add(this.changeUserDataButton);
            this.Controls.Add(this.chooseUserButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.saveUserButton);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Name = "UserForm";
            this.Text = "Меню пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button chooseUserButton;
        private System.Windows.Forms.Button changeUserDataButton;
    }
}