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
            this.SuspendLayout();
            // 
            // saveUserButton
            // 
            this.saveUserButton.Location = new System.Drawing.Point(89, 149);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(170, 58);
            this.saveUserButton.TabIndex = 0;
            this.saveUserButton.Text = "Сохранить пользователя";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.AccessibleDescription = "Имя";
            this.firstNameTextBox.Location = new System.Drawing.Point(89, 71);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Text = "Имя";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lastNameTextBox.Location = new System.Drawing.Point(89, 97);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.Text = "Фамилия";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(89, 213);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(170, 58);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Удалить пользователя";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idTextBox.Location = new System.Drawing.Point(89, 123);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(170, 20);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.Text = "Числовой индентификатор";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 351);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.saveUserButton);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Name = "UserForm";
            this.Text = "CreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.TextBox idTextBox;
    }
}