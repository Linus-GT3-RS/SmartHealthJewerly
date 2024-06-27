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
         this.LoginButton = new System.Windows.Forms.Button();
         this.emailTextBox = new System.Windows.Forms.TextBox();
         this.PasswordTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.labelSignInText = new System.Windows.Forms.Label();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.label2 = new System.Windows.Forms.Label();
         this.labelSignIn = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // LoginButton
         // 
         this.LoginButton.BackColor = System.Drawing.Color.White;
         this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.LoginButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
         this.LoginButton.ForeColor = System.Drawing.Color.Black;
         this.LoginButton.Location = new System.Drawing.Point(297, 372);
         this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.LoginButton.Name = "LoginButton";
         this.LoginButton.Size = new System.Drawing.Size(282, 58);
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
         this.emailTextBox.Location = new System.Drawing.Point(170, 172);
         this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.emailTextBox.Name = "emailTextBox";
         this.emailTextBox.Size = new System.Drawing.Size(562, 42);
         this.emailTextBox.TabIndex = 3;
         this.emailTextBox.Text = "e-mail";
         this.emailTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.emailTextBox_MouseClick);
         this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
         // 
         // PasswordTextBox
         // 
         this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic);
         this.PasswordTextBox.ForeColor = System.Drawing.Color.LightGray;
         this.PasswordTextBox.Location = new System.Drawing.Point(170, 252);
         this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.PasswordTextBox.Name = "PasswordTextBox";
         this.PasswordTextBox.Size = new System.Drawing.Size(562, 42);
         this.PasswordTextBox.TabIndex = 3;
         this.PasswordTextBox.Text = "password";
         this.PasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
         this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
         // 
         // label1
         // 
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
         this.label1.ForeColor = System.Drawing.Color.Black;
         this.label1.Location = new System.Drawing.Point(371, 57);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(160, 63);
         this.label1.TabIndex = 4;
         this.label1.Text = "Login";
         // 
         // labelSignInText
         // 
         this.labelSignInText.BackColor = System.Drawing.Color.Transparent;
         this.labelSignInText.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.labelSignInText.ForeColor = System.Drawing.Color.Black;
         this.labelSignInText.Location = new System.Drawing.Point(297, 434);
         this.labelSignInText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.labelSignInText.Name = "labelSignInText";
         this.labelSignInText.Size = new System.Drawing.Size(181, 48);
         this.labelSignInText.TabIndex = 5;
         this.labelSignInText.Text = "Not registered yet?";
         this.labelSignInText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.BackColor = System.Drawing.Color.Transparent;
         this.checkBox1.ForeColor = System.Drawing.Color.Black;
         this.checkBox1.Location = new System.Drawing.Point(170, 325);
         this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(179, 24);
         this.checkBox1.TabIndex = 6;
         this.checkBox1.Text = "remember password";
         this.checkBox1.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.ForeColor = System.Drawing.Color.Black;
         this.label2.Location = new System.Drawing.Point(600, 326);
         this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(132, 20);
         this.label2.TabIndex = 7;
         this.label2.Text = "forgot password?";
         // 
         // labelSignIn
         // 
         this.labelSignIn.BackColor = System.Drawing.Color.Transparent;
         this.labelSignIn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
         this.labelSignIn.ForeColor = System.Drawing.Color.Black;
         this.labelSignIn.Location = new System.Drawing.Point(466, 435);
         this.labelSignIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.labelSignIn.Name = "labelSignIn";
         this.labelSignIn.Size = new System.Drawing.Size(113, 48);
         this.labelSignIn.TabIndex = 8;
         this.labelSignIn.Text = "Sign In";
         this.labelSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.labelSignIn.Click += new System.EventHandler(this.labelSignIn_Click);
         // 
         // LogIn_Form
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(900, 563);
         this.Controls.Add(this.labelSignIn);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.checkBox1);
         this.Controls.Add(this.labelSignInText);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.PasswordTextBox);
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
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private Label labelSignInText;
        private CheckBox checkBox1;
        private Label label2;
      private Label labelSignIn;
   }
}