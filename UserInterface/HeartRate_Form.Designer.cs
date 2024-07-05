namespace UserInterface
{
   partial class HeartRate_Form
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
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         this.button1 = new System.Windows.Forms.Button();
         this.chartHeartbeat = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.labelBPM = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.chartHeartbeat)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(12, 612);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(166, 51);
         this.button1.TabIndex = 0;
         this.button1.Text = "Go Back to Home";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // chartHeartbeat
         // 
         this.chartHeartbeat.BackColor = System.Drawing.Color.SteelBlue;
         chartArea1.Name = "ChartArea1";
         chartArea1.AxisY.Minimum = 600;
         chartArea1.AxisY.Maximum = 800;
         this.chartHeartbeat.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         this.chartHeartbeat.Legends.Add(legend1);
         this.chartHeartbeat.Location = new System.Drawing.Point(2, 1);
         this.chartHeartbeat.Name = "chartHeartbeat";
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
         series1.Legend = "Legend1";
         series1.Name = "Series1";
         this.chartHeartbeat.Series.Add(series1);
         this.chartHeartbeat.Size = new System.Drawing.Size(1186, 559);
         this.chartHeartbeat.TabIndex = 11;
         this.chartHeartbeat.Text = "chartHeartRate";
         // 
         // labelBPM
         // 
         this.labelBPM.AutoSize = true;
         this.labelBPM.Location = new System.Drawing.Point(551, 627);
         this.labelBPM.Name = "labelBPM";
         this.labelBPM.Size = new System.Drawing.Size(65, 30);
         this.labelBPM.TabIndex = 12;
         this.labelBPM.Text = "BPM";
         // 
         // HeartRate_Form
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1245, 673);
         this.Controls.Add(this.labelBPM);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.chartHeartbeat);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "HeartRate_Form";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "HeartRate_Form";
         ((System.ComponentModel.ISupportInitialize)(this.chartHeartbeat)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.Button button1;
      private System.Windows.Forms.DataVisualization.Charting.Chart chartHeartbeat;
      private System.Windows.Forms.Label labelBPM;
   }
}