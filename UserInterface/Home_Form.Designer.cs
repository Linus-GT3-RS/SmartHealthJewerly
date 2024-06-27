using System.Windows.Forms;
using System.Drawing;
using BackendCS;

namespace UserInterface
{
    partial class Home_Form
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
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(679, 480);
         this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(200, 58);
         this.button1.TabIndex = 0;
         this.button1.Text = "Go to health data";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(392, 85);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(49, 20);
         this.label1.TabIndex = 1;
         this.label1.Text = "Hello ";
         // 
         // Home_Form
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(900, 562);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.button1);
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Name = "Home_Form";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Home_Forms";
         this.Shown += new System.EventHandler(this.Home_Form_Shown);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
      private Label label1;
   }
}