﻿namespace UserInterface
{
    partial class Manager_Form
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
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(161, 244);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(616, 46);
         this.label1.TabIndex = 0;
         this.label1.Text = "THIS FORM IS NOT DISPLAYED";
         // 
         // Manager_Form
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(900, 562);
         this.Controls.Add(this.label1);
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Name = "Manager_Form";
         this.Text = "Manager_Form";
         this.Load += new System.EventHandler(this.Manager_Form_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}