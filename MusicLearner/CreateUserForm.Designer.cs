namespace MusicLearner
{
    partial class CreateUserForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.AccessibleDescription = "Имя";
            this.firstNameTextBox.Location = new System.Drawing.Point(89, 97);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(170, 20);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.Text = "Имя";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 2;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 351);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.button1);
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}