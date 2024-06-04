using System;
using System.Reflection;

namespace UserInterface
{
    partial class SplashScreen_Form
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
            // circProgressBar.Dispose();
            timer1.Dispose();

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen_Form));
            this.circProgressBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // circProgressBar
            // 
            this.circProgressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circProgressBar.AnimationFunction")));
            this.circProgressBar.AnimationSpeed = 100;
            this.circProgressBar.BackColor = System.Drawing.Color.White;
            this.circProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circProgressBar.InnerMargin = 2;
            this.circProgressBar.InnerWidth = -1;
            this.circProgressBar.Location = new System.Drawing.Point(189, 52);
            this.circProgressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.circProgressBar.MarqueeAnimationSpeed = 2000;
            this.circProgressBar.Name = "circProgressBar";
            this.circProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circProgressBar.OuterMargin = -25;
            this.circProgressBar.OuterWidth = 26;
            this.circProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circProgressBar.ProgressWidth = 6;
            this.circProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circProgressBar.Size = new System.Drawing.Size(298, 288);
            this.circProgressBar.StartAngle = 270;
            this.circProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circProgressBar.SubscriptText = "";
            this.circProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circProgressBar.SuperscriptText = "";
            this.circProgressBar.TabIndex = 0;
            this.circProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circProgressBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circProgressBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SplashScreen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashScreen_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar circProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

