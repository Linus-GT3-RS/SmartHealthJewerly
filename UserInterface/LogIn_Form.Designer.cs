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
            this.loginnameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.labelSignInText = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictboxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // loginnameTextBox
            // 
            this.loginnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.loginnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.loginnameTextBox.Location = new System.Drawing.Point(94, 269);
            this.loginnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginnameTextBox.Name = "loginnameTextBox";
            this.loginnameTextBox.Size = new System.Drawing.Size(295, 27);
            this.loginnameTextBox.TabIndex = 0;
            this.loginnameTextBox.TabStop = false;
            this.loginnameTextBox.Text = "e-mail";
            this.loginnameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.emailTextBox_MouseClick);
            this.loginnameTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.loginnameTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(94, 361);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(295, 27);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TabStop = false;
            this.PasswordTextBox.Text = "password";
            this.PasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // labelSignInText
            // 
            this.labelSignInText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.labelSignInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignInText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.labelSignInText.Location = new System.Drawing.Point(100, 573);
            this.labelSignInText.Margin = new System.Windows.Forms.Padding(0);
            this.labelSignInText.Name = "labelSignInText";
            this.labelSignInText.Size = new System.Drawing.Size(220, 61);
            this.labelSignInText.TabIndex = 5;
            this.labelSignInText.Text = "Don\'t have an account?";
            this.labelSignInText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.checkBox1.Location = new System.Drawing.Point(65, 425);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(309, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Forgot password?";
            // 
            // labelSignIn
            // 
            this.labelSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.labelSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(233)))));
            this.labelSignIn.Location = new System.Drawing.Point(320, 583);
            this.labelSignIn.Margin = new System.Windows.Forms.Padding(0);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(114, 40);
            this.labelSignIn.TabIndex = 8;
            this.labelSignIn.Text = "Register";
            this.labelSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSignIn.Click += new System.EventHandler(this.labelSignIn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = global::UserInterface.Properties.Resources.Login_Template___LoginButton;
            this.btnLogin.Location = new System.Drawing.Point(60, 487);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.MaximumSize = new System.Drawing.Size(409, 69);
            this.btnLogin.MinimumSize = new System.Drawing.Size(409, 69);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(409, 69);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // pictboxBackground
            // 
            this.pictboxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictboxBackground.Image = global::UserInterface.Properties.Resources.Login_Template___Background1;
            this.pictboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictboxBackground.MaximumSize = new System.Drawing.Size(528, 673);
            this.pictboxBackground.MinimumSize = new System.Drawing.Size(528, 673);
            this.pictboxBackground.Name = "pictboxBackground";
            this.pictboxBackground.Size = new System.Drawing.Size(528, 673);
            this.pictboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictboxBackground.TabIndex = 9;
            this.pictboxBackground.TabStop = false;
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(105)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 673);
            this.Controls.Add(this.labelSignInText);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.loginnameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictboxBackground);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(528, 673);
            this.MinimumSize = new System.Drawing.Size(528, 673);
            this.Name = "LogIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInScreen_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictboxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox loginnameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private Label labelSignInText;
        private CheckBox checkBox1;
        private Label label2;
      private Label labelSignIn;
        private PictureBox pictboxBackground;
    }
}