using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace UserInterface
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelBPM = new System.Windows.Forms.Label();
            this.labelBodyTemp = new System.Windows.Forms.Label();
            this.labelEnvTemp = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.labelMotionAccX = new System.Windows.Forms.Label();
            this.labelMotionAccY = new System.Windows.Forms.Label();
            this.labelMotionAccZ = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.chartHeartbeat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeartbeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(58, 42);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(178, 80);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start Measurement";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelBPM
            // 
            this.labelBPM.AutoSize = true;
            this.labelBPM.Location = new System.Drawing.Point(32, 317);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(186, 25);
            this.labelBPM.TabIndex = 1;
            this.labelBPM.Text = "Beats per minute: ";
            // 
            // labelBodyTemp
            // 
            this.labelBodyTemp.AutoSize = true;
            this.labelBodyTemp.Location = new System.Drawing.Point(32, 524);
            this.labelBodyTemp.Name = "labelBodyTemp";
            this.labelBodyTemp.Size = new System.Drawing.Size(194, 25);
            this.labelBodyTemp.TabIndex = 2;
            this.labelBodyTemp.Text = "Body temperature: ";
            // 
            // labelEnvTemp
            // 
            this.labelEnvTemp.AutoSize = true;
            this.labelEnvTemp.Location = new System.Drawing.Point(32, 372);
            this.labelEnvTemp.Name = "labelEnvTemp";
            this.labelEnvTemp.Size = new System.Drawing.Size(265, 25);
            this.labelEnvTemp.TabIndex = 3;
            this.labelEnvTemp.Text = "Environment temperature: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(32, 425);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(230, 25);
            this.labelHumidity.TabIndex = 4;
            this.labelHumidity.Text = "Environment humidity: ";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(32, 475);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(126, 25);
            this.labelBrightness.TabIndex = 5;
            this.labelBrightness.Text = "Brightness: ";
            // 
            // labelMotionAccX
            // 
            this.labelMotionAccX.AutoSize = true;
            this.labelMotionAccX.Location = new System.Drawing.Point(32, 567);
            this.labelMotionAccX.Name = "labelMotionAccX";
            this.labelMotionAccX.Size = new System.Drawing.Size(139, 25);
            this.labelMotionAccX.TabIndex = 6;
            this.labelMotionAccX.Text = "MotionAccX: ";
            // 
            // labelMotionAccY
            // 
            this.labelMotionAccY.AutoSize = true;
            this.labelMotionAccY.Location = new System.Drawing.Point(32, 614);
            this.labelMotionAccY.Name = "labelMotionAccY";
            this.labelMotionAccY.Size = new System.Drawing.Size(140, 25);
            this.labelMotionAccY.TabIndex = 7;
            this.labelMotionAccY.Text = "MotionAccY: ";
            // 
            // labelMotionAccZ
            // 
            this.labelMotionAccZ.AutoSize = true;
            this.labelMotionAccZ.Location = new System.Drawing.Point(32, 663);
            this.labelMotionAccZ.Name = "labelMotionAccZ";
            this.labelMotionAccZ.Size = new System.Drawing.Size(138, 25);
            this.labelMotionAccZ.TabIndex = 8;
            this.labelMotionAccZ.Text = "MotionAccZ: ";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(58, 151);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(178, 72);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop Measurement";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHeartbeat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHeartbeat.Legends.Add(legend1);
            this.chartHeartbeat.Location = new System.Drawing.Point(399, 11);
            this.chartHeartbeat.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHeartbeat.Series.Add(series1);
            this.chartHeartbeat.Size = new System.Drawing.Size(840, 355);
            this.chartHeartbeat.TabIndex = 10;
            this.chartHeartbeat.Text = "chartHeartRate";
            // 
            // chartHeight
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHeight.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHeight.Legends.Add(legend2);
            this.chartHeight.Location = new System.Drawing.Point(399, 378);
            this.chartHeight.Name = "chartHeight";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHeight.Series.Add(series2);
            this.chartHeight.Size = new System.Drawing.Size(417, 326);
         chartHeight.ChartAreas[0].AxisY.Minimum = -185; // Set the minimum y-axis value
         chartHeight.ChartAreas[0].AxisY.Maximum = 185;  // Set the maximum y-axis value
            this.chartHeight.TabIndex = 11;
            this.chartHeight.Text = "chartHeight";
            // 
            // chartDistance
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDistance.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDistance.Legends.Add(legend3);
            this.chartDistance.Location = new System.Drawing.Point(822, 378);
            this.chartDistance.Name = "chartDistance";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDistance.Series.Add(series3);
            this.chartDistance.Size = new System.Drawing.Size(417, 326);
            this.chartDistance.TabIndex = 12;
            this.chartDistance.Text = "chartDistance";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1353, 835);
            this.Controls.Add(this.chartDistance);
            this.Controls.Add(this.chartHeight);
            this.Controls.Add(this.chartHeartbeat);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelMotionAccZ);
            this.Controls.Add(this.labelMotionAccY);
            this.Controls.Add(this.labelMotionAccX);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelEnvTemp);
            this.Controls.Add(this.labelBodyTemp);
            this.Controls.Add(this.labelBPM);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartHeartbeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button buttonStart;
        private Label labelBPM;
        private Label labelBodyTemp;
        private Label labelEnvTemp;
        private Label labelHumidity;
        private Label labelBrightness;
        private Label labelMotionAccX;
        private Label labelMotionAccY;
        private Label labelMotionAccZ;
        private Button buttonStop;
        private Series series1;
        private Chart chartHeartbeat;
        private Chart chartHeight;
        private Chart chartDistance;
    }
}

