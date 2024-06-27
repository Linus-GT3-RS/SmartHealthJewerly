using System.Windows.Forms;
using System.Drawing;


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
            this.BackgroundImage = Image.FromFile("C:\\Users\\dennisapelt\\source\\repos\\SmartHealthJewerly\\UserInterface\\hintergrund.jpeg"); // Pfad zum Bild angeben
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.LoginButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(396, 465);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(376, 72);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            this.emailTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.emailTextBox.Location = new System.Drawing.Point(227, 215);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(750, 56);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Text = "e-mail";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.Location = new System.Drawing.Point(227, 315);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(750, 56);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "password";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(495, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 79);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // labelSignIn
            // 
            this.labelSignIn.BackColor = System.Drawing.Color.Transparent;
            this.labelSignIn.ForeColor = System.Drawing.Color.Black;
            this.labelSignIn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.labelSignIn.Location = new System.Drawing.Point(396, 543);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(376, 60);
            this.labelSignIn.TabIndex = 5;
            this.labelSignIn.Text = "Not registered yet? Sign up";
            this.labelSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(227, 406);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(238, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "remember password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "forgot password?";
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.LoginButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInScreen_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.Button LoginButton;
      private System.Windows.Forms.TextBox emailTextBox;
      private System.Windows.Forms.TextBox PasswordTextBox;
      private System.Windows.Forms.Label label1;
      private Label labelSignIn;
        private CheckBox checkBox1;
        private Label label2;
    }
}