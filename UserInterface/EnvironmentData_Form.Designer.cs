namespace UserInterface
{
   partial class EnvironmentData_Form
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
         this.Header_label = new System.Windows.Forms.Label();
         this.labelHumidity = new System.Windows.Forms.Label();
         this.labelEnvTemp = new System.Windows.Forms.Label();
         this.labelBrightness = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(2, 391);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(139, 57);
         this.button1.TabIndex = 0;
         this.button1.Text = "Go back to home";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // Header_label
         // 
         this.Header_label.AutoSize = true;
         this.Header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Header_label.Location = new System.Drawing.Point(187, 40);
         this.Header_label.Name = "Header_label";
         this.Header_label.Size = new System.Drawing.Size(360, 46);
         this.Header_label.TabIndex = 1;
         this.Header_label.Text = "Environement Data";
         // 
         // labelHumidity
         // 
         this.labelHumidity.AutoSize = true;
         this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
         this.labelHumidity.ForeColor = System.Drawing.Color.Black;
         this.labelHumidity.Location = new System.Drawing.Point(24, 204);
         this.labelHumidity.Name = "labelHumidity";
         this.labelHumidity.Size = new System.Drawing.Size(168, 20);
         this.labelHumidity.TabIndex = 4;
         this.labelHumidity.Text = "Environment humidity: ";
         // 
         // labelEnvTemp
         // 
         this.labelEnvTemp.AutoSize = true;
         this.labelEnvTemp.BackColor = System.Drawing.Color.Transparent;
         this.labelEnvTemp.ForeColor = System.Drawing.Color.Black;
         this.labelEnvTemp.Location = new System.Drawing.Point(24, 160);
         this.labelEnvTemp.Name = "labelEnvTemp";
         this.labelEnvTemp.Size = new System.Drawing.Size(197, 20);
         this.labelEnvTemp.TabIndex = 3;
         this.labelEnvTemp.Text = "Environment temperature: ";
         // 
         // labelBrightness
         // 
         this.labelBrightness.AutoSize = true;
         this.labelBrightness.BackColor = System.Drawing.Color.Transparent;
         this.labelBrightness.ForeColor = System.Drawing.Color.Black;
         this.labelBrightness.Location = new System.Drawing.Point(24, 303);
         this.labelBrightness.Name = "labelBrightness";
         this.labelBrightness.Size = new System.Drawing.Size(144, 20);
         this.labelBrightness.TabIndex = 2;
         this.labelBrightness.Text = "Body temperature: ";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.ForeColor = System.Drawing.Color.Black;
         this.label4.Location = new System.Drawing.Point(24, 254);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(93, 20);
         this.label4.TabIndex = 5;
         this.label4.Text = "Brightness: ";
         // 
         // EnvironmentData_Form
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.Header_label);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.labelHumidity);
         this.Controls.Add(this.labelEnvTemp);
         this.Controls.Add(this.labelBrightness);
         this.Controls.Add(this.label4);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "EnvironmentData_Form";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "EnvironmentData_Form";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label Header_label;
      private System.Windows.Forms.Label labelHumidity;
      private System.Windows.Forms.Label labelEnvTemp;
      private System.Windows.Forms.Label labelBrightness;
      private System.Windows.Forms.Label label4;
   }
}