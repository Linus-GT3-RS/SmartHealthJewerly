﻿using System.Windows.Forms.DataVisualization.Charting;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeartbeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.labelBPM.Location = new System.Drawing.Point(32, 272);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(186, 25);
            this.labelBPM.TabIndex = 1;
            this.labelBPM.Text = "Beats per minute: ";
            // 
            // labelBodyTemp
            // 
            this.labelBodyTemp.AutoSize = true;
            this.labelBodyTemp.Location = new System.Drawing.Point(32, 457);
            this.labelBodyTemp.Name = "labelBodyTemp";
            this.labelBodyTemp.Size = new System.Drawing.Size(194, 25);
            this.labelBodyTemp.TabIndex = 2;
            this.labelBodyTemp.Text = "Body temperature: ";
            // 
            // labelEnvTemp
            // 
            this.labelEnvTemp.AutoSize = true;
            this.labelEnvTemp.Location = new System.Drawing.Point(32, 314);
            this.labelEnvTemp.Name = "labelEnvTemp";
            this.labelEnvTemp.Size = new System.Drawing.Size(265, 25);
            this.labelEnvTemp.TabIndex = 3;
            this.labelEnvTemp.Text = "Environment temperature: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(32, 358);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(230, 25);
            this.labelHumidity.TabIndex = 4;
            this.labelHumidity.Text = "Environment humidity: ";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(32, 408);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(126, 25);
            this.labelBrightness.TabIndex = 5;
            this.labelBrightness.Text = "Brightness: ";
            // 
            // labelMotionAccX
            // 
            this.labelMotionAccX.AutoSize = true;
            this.labelMotionAccX.Location = new System.Drawing.Point(32, 500);
            this.labelMotionAccX.Name = "labelMotionAccX";
            this.labelMotionAccX.Size = new System.Drawing.Size(139, 25);
            this.labelMotionAccX.TabIndex = 6;
            this.labelMotionAccX.Text = "MotionAccX: ";
            // 
            // labelMotionAccY
            // 
            this.labelMotionAccY.AutoSize = true;
            this.labelMotionAccY.Location = new System.Drawing.Point(32, 547);
            this.labelMotionAccY.Name = "labelMotionAccY";
            this.labelMotionAccY.Size = new System.Drawing.Size(140, 25);
            this.labelMotionAccY.TabIndex = 7;
            this.labelMotionAccY.Text = "MotionAccY: ";
            // 
            // labelMotionAccZ
            // 
            this.labelMotionAccZ.AutoSize = true;
            this.labelMotionAccZ.Location = new System.Drawing.Point(32, 596);
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
            // chartHeartbeat
            // 
            chartArea4.Name = "ChartArea1";
            this.chartHeartbeat.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartHeartbeat.Legends.Add(legend4);
            this.chartHeartbeat.Location = new System.Drawing.Point(399, 4);
            this.chartHeartbeat.Name = "chartHeartbeat";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartHeartbeat.Series.Add(series8);
            this.chartHeartbeat.Size = new System.Drawing.Size(840, 323);
            this.chartHeartbeat.TabIndex = 10;
            this.chartHeartbeat.Text = "chartHeartRate";
            // 
            // chartHeight
            // 
            chartArea5.Name = "ChartArea1";
            this.chartHeight.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartHeight.Legends.Add(legend5);
            this.chartHeight.Location = new System.Drawing.Point(399, 333);
            this.chartHeight.Name = "chartHeight";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "SeriesXAcc";
            series10.ChartArea = "ChartArea1";
            series10.Enabled = false;
            series10.Legend = "Legend1";
            series10.Name = "SeriesYAcc";
            series11.ChartArea = "ChartArea1";
            series11.Enabled = false;
            series11.Legend = "Legend1";
            series11.Name = "SeriesZAcc";
            this.chartHeight.Series.Add(series9);
            this.chartHeight.Series.Add(series10);
            this.chartHeight.Series.Add(series11);
            this.chartHeight.Size = new System.Drawing.Size(417, 326);
            this.chartHeight.TabIndex = 11;
            this.chartHeight.Text = "chartHeight";
            // 
            // chartDistance
            // 
            chartArea6.Name = "ChartArea1";
            this.chartDistance.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartDistance.Legends.Add(legend6);
            this.chartDistance.Location = new System.Drawing.Point(822, 333);
            this.chartDistance.Name = "chartDistance";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "SeriesXGyro";
            series13.ChartArea = "ChartArea1";
            series13.Enabled = false;
            series13.Legend = "Legend1";
            series13.Name = "SeriesYGyro";
            series14.ChartArea = "ChartArea1";
            series14.Enabled = false;
            series14.Legend = "Legend1";
            series14.Name = "SeriesZGyro";
            this.chartDistance.Series.Add(series12);
            this.chartDistance.Series.Add(series13);
            this.chartDistance.Series.Add(series14);
            this.chartDistance.Size = new System.Drawing.Size(417, 326);
            this.chartDistance.TabIndex = 12;
            this.chartDistance.Text = "chartDistance";
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Checked = true;
            this.radioButtonX.Location = new System.Drawing.Point(3, 3);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(105, 29);
            this.radioButtonX.TabIndex = 13;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "X-Axis";
            this.radioButtonX.UseVisualStyleBackColor = true;
            this.radioButtonX.CheckedChanged += new System.EventHandler(this.radioButtonX_CheckedChanged);
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.Location = new System.Drawing.Point(183, 3);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.Size = new System.Drawing.Size(106, 29);
            this.radioButtonY.TabIndex = 14;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "Y-Axis";
            this.radioButtonY.UseVisualStyleBackColor = true;
            this.radioButtonY.CheckedChanged += new System.EventHandler(this.radioButtonY_CheckedChanged);
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.Location = new System.Drawing.Point(343, 3);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(104, 29);
            this.radioButtonZ.TabIndex = 15;
            this.radioButtonZ.TabStop = true;
            this.radioButtonZ.Text = "Z-Axis";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            this.radioButtonZ.CheckedChanged += new System.EventHandler(this.radioButtonZ_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonX);
            this.panel1.Controls.Add(this.radioButtonZ);
            this.panel1.Controls.Add(this.radioButtonY);
            this.panel1.Location = new System.Drawing.Point(589, 665);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 40);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1353, 835);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private RadioButton radioButtonX;
        private RadioButton radioButtonY;
        private RadioButton radioButtonZ;
        private Panel panel1;
    }
}

