namespace UserInterface
{
    partial class LogIn_Form
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
         this.LoginButton = new System.Windows.Forms.Button();
         this.emailTextBox = new System.Windows.Forms.TextBox();
         this.SigUpButton = new System.Windows.Forms.Button();
         this.PasswordTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // LoginButton
         // 
         this.LoginButton.BackColor = System.Drawing.Color.Blue;
         this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.LoginButton.Location = new System.Drawing.Point(170, 388);
         this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.LoginButton.Name = "LoginButton";
         this.LoginButton.Size = new System.Drawing.Size(282, 35);
         this.LoginButton.TabIndex = 0;
         this.LoginButton.Text = "Log In";
         this.LoginButton.UseVisualStyleBackColor = false;
         this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
         // 
         // emailTextBox
         // 
         this.emailTextBox.Location = new System.Drawing.Point(170, 112);
         this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.emailTextBox.Name = "emailTextBox";
         this.emailTextBox.Size = new System.Drawing.Size(556, 26);
         this.emailTextBox.TabIndex = 1;
         // 
         // SigUpButton
         // 
         this.SigUpButton.BackColor = System.Drawing.Color.Blue;
         this.SigUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.SigUpButton.Location = new System.Drawing.Point(460, 388);
         this.SigUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.SigUpButton.Name = "SigUpButton";
         this.SigUpButton.Size = new System.Drawing.Size(267, 35);
         this.SigUpButton.TabIndex = 2;
         this.SigUpButton.Text = "Sign Up";
         this.SigUpButton.UseVisualStyleBackColor = false;
         this.SigUpButton.Click += new System.EventHandler(this.SigUpButton_Click);
         // 
         // PasswordTextBox
         // 
         this.PasswordTextBox.Location = new System.Drawing.Point(170, 246);
         this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.PasswordTextBox.Name = "PasswordTextBox";
         this.PasswordTextBox.Size = new System.Drawing.Size(556, 26);
         this.PasswordTextBox.TabIndex = 3;
         // 
         // LogIn_Form
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(900, 563);
         this.Controls.Add(this.PasswordTextBox);
         this.Controls.Add(this.SigUpButton);
         this.Controls.Add(this.emailTextBox);
         this.Controls.Add(this.LoginButton);
         this.Name = "LogIn_Form";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "LogInScreen_Form";
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Button LoginButton;
      private System.Windows.Forms.TextBox emailTextBox;
      private System.Windows.Forms.Button SigUpButton;
      private System.Windows.Forms.TextBox PasswordTextBox;
   }
}