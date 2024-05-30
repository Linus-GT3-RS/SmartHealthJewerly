using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace GUI_Toto
{
   partial class Form1
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
         System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
         this.HerzschlagSpannungsLabel = new System.Windows.Forms.Label();
         this.luftfeuchtigkeitsLabel = new System.Windows.Forms.Label();
         this.temperaturLabel = new System.Windows.Forms.Label();
         this.BPMLabel = new System.Windows.Forms.Label();
         this.dully = new System.Windows.Forms.Label();
         this.KoerperTemperaturLabel = new System.Windows.Forms.Label();
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.SuspendLayout();
         // 
         // HerzschlagSpannungsLabel
         // 
         this.HerzschlagSpannungsLabel.AutoSize = true;
         this.HerzschlagSpannungsLabel.Location = new System.Drawing.Point(31, 39);
         this.HerzschlagSpannungsLabel.Name = "HerzschlagSpannungsLabel";
         this.HerzschlagSpannungsLabel.Size = new System.Drawing.Size(51, 20);
         this.HerzschlagSpannungsLabel.TabIndex = 0;
         this.HerzschlagSpannungsLabel.Text = "label1";
         // 
         // luftfeuchtigkeitsLabel
         // 
         this.luftfeuchtigkeitsLabel.AutoSize = true;
         this.luftfeuchtigkeitsLabel.Location = new System.Drawing.Point(35, 92);
         this.luftfeuchtigkeitsLabel.Name = "luftfeuchtigkeitsLabel";
         this.luftfeuchtigkeitsLabel.Size = new System.Drawing.Size(51, 20);
         this.luftfeuchtigkeitsLabel.TabIndex = 1;
         this.luftfeuchtigkeitsLabel.Text = "label1";
         // 
         // temperaturLabel
         // 
         this.temperaturLabel.AutoSize = true;
         this.temperaturLabel.Location = new System.Drawing.Point(35, 148);
         this.temperaturLabel.Name = "temperaturLabel";
         this.temperaturLabel.Size = new System.Drawing.Size(51, 20);
         this.temperaturLabel.TabIndex = 2;
         this.temperaturLabel.Text = "label2";
         // 
         // BPMLabel
         // 
         this.BPMLabel.AutoSize = true;
         this.BPMLabel.Location = new System.Drawing.Point(190, 39);
         this.BPMLabel.Name = "BPMLabel";
         this.BPMLabel.Size = new System.Drawing.Size(51, 20);
         this.BPMLabel.TabIndex = 3;
         this.BPMLabel.Text = "label1";
         // 
         // dully
         // 
         this.dully.AutoSize = true;
         this.dully.Location = new System.Drawing.Point(194, 114);
         this.dully.Name = "dully";
         this.dully.Size = new System.Drawing.Size(51, 20);
         this.dully.TabIndex = 4;
         this.dully.Text = "label1";
         // 
         // KoerperTemperaturLabel
         // 
         this.KoerperTemperaturLabel.AutoSize = true;
         this.KoerperTemperaturLabel.Location = new System.Drawing.Point(185, 181);
         this.KoerperTemperaturLabel.Name = "KoerperTemperaturLabel";
         this.KoerperTemperaturLabel.Size = new System.Drawing.Size(51, 20);
         this.KoerperTemperaturLabel.TabIndex = 5;
         this.KoerperTemperaturLabel.Text = "label1";
         // 
         // chart1
         // 
         chartArea1.Name = "ChartArea1";
         this.chart1.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         this.chart1.Legends.Add(legend1);
         this.chart1.Location = new System.Drawing.Point(349, 27);
         this.chart1.Name = "chart1";
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
         series1.Legend = "Legend1";
         series1.Name = "HeartRate";
         series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
         series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
         this.chart1.Series.Add(series1);
         this.chart1.Size = new System.Drawing.Size(602, 308);
         this.chart1.TabIndex = 6;
         this.chart1.Text = "chart1";
         title1.Name = "Title1";
         this.chart1.Titles.Add(title1);
         chart1.ChartAreas[0].AxisY.Minimum = 600; // Set the minimum y-axis value
         chart1.ChartAreas[0].AxisY.Maximum = 800; // Set the maximum y-axis value
         chart1.ChartAreas[0].AxisX.Minimum = 0; // Set the minimum x-axis value
         chart1.ChartAreas[0].AxisX.Maximum = 100; // Set the maximum x-axis value

         // 
         // Form1
         // 
         this.ClientSize = new System.Drawing.Size(991, 441);
         this.Controls.Add(this.chart1);
         this.Controls.Add(this.KoerperTemperaturLabel);
         this.Controls.Add(this.dully);
         this.Controls.Add(this.BPMLabel);
         this.Controls.Add(this.temperaturLabel);
         this.Controls.Add(this.luftfeuchtigkeitsLabel);
         this.Controls.Add(this.HerzschlagSpannungsLabel);
         this.Name = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();



      }

      #endregion

      private System.Windows.Forms.Label HerzschlagSpannungsLabel;
      private System.Windows.Forms.Label luftfeuchtigkeitsLabel;
      private System.Windows.Forms.Label temperaturLabel;
      private System.Windows.Forms.Label BPMLabel;
      private System.Windows.Forms.Label dully;
      private System.Windows.Forms.Label KoerperTemperaturLabel;
      private Chart chart1;
   }
}

