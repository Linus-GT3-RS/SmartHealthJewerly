using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace UserInterface
{
    partial class HealthData_Form
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthData_Form));
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelBPM = new System.Windows.Forms.Label();
            this.labelBodyTemp = new System.Windows.Forms.Label();
            this.labelEnvTemp = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.chartHeartbeat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.labelBPM.BackColor = System.Drawing.Color.Transparent;
            this.labelBPM.ForeColor = System.Drawing.Color.Black;
            this.labelBPM.Location = new System.Drawing.Point(32, 272);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(186, 25);
            this.labelBPM.TabIndex = 1;
            this.labelBPM.Text = "Beats per minute: ";
            // 
            // labelBodyTemp
            // 
            this.labelBodyTemp.AutoSize = true;
            this.labelBodyTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelBodyTemp.ForeColor = System.Drawing.Color.Black;
            this.labelBodyTemp.Location = new System.Drawing.Point(32, 457);
            this.labelBodyTemp.Name = "labelBodyTemp";
            this.labelBodyTemp.Size = new System.Drawing.Size(194, 25);
            this.labelBodyTemp.TabIndex = 2;
            this.labelBodyTemp.Text = "Body temperature: ";
            // 
            // labelEnvTemp
            // 
            this.labelEnvTemp.AutoSize = true;
            this.labelEnvTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelEnvTemp.ForeColor = System.Drawing.Color.Black;
            this.labelEnvTemp.Location = new System.Drawing.Point(32, 314);
            this.labelEnvTemp.Name = "labelEnvTemp";
            this.labelEnvTemp.Size = new System.Drawing.Size(265, 25);
            this.labelEnvTemp.TabIndex = 3;
            this.labelEnvTemp.Text = "Environment temperature: ";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidity.ForeColor = System.Drawing.Color.Black;
            this.labelHumidity.Location = new System.Drawing.Point(32, 358);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(230, 25);
            this.labelHumidity.TabIndex = 4;
            this.labelHumidity.Text = "Environment humidity: ";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.BackColor = System.Drawing.Color.Transparent;
            this.labelBrightness.ForeColor = System.Drawing.Color.Black;
            this.labelBrightness.Location = new System.Drawing.Point(32, 408);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(126, 25);
            this.labelBrightness.TabIndex = 5;
            this.labelBrightness.Text = "Brightness: ";
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
            this.chartHeartbeat.BackColor = System.Drawing.Color.SteelBlue;
            chartArea1.Name = "ChartArea1";
            this.chartHeartbeat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHeartbeat.Legends.Add(legend1);
            this.chartHeartbeat.Location = new System.Drawing.Point(399, 4);
            this.chartHeartbeat.Name = "chartHeartbeat";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartHeartbeat.Series.Add(series1);
            this.chartHeartbeat.Size = new System.Drawing.Size(840, 323);
            this.chartHeartbeat.TabIndex = 10;
            this.chartHeartbeat.Text = "chartHeartRate";
            // 
            // chartHeight
            // 
            this.chartHeight.BackColor = System.Drawing.Color.SteelBlue;
            chartArea2.Name = "ChartArea1";
            this.chartHeight.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHeight.Legends.Add(legend2);
            this.chartHeight.Location = new System.Drawing.Point(399, 333);
            this.chartHeight.Name = "chartHeight";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SeriesXAcc";
            series3.ChartArea = "ChartArea1";
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "SeriesYAcc";
            series4.ChartArea = "ChartArea1";
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.Name = "SeriesZAcc";
            this.chartHeight.Series.Add(series2);
            this.chartHeight.Series.Add(series3);
            this.chartHeight.Series.Add(series4);
            this.chartHeight.Size = new System.Drawing.Size(417, 288);
            this.chartHeight.TabIndex = 11;
            this.chartHeight.Text = "chartHeight";
            // 
            // chartDistance
            // 
            this.chartDistance.BackColor = System.Drawing.Color.SteelBlue;
            chartArea3.Name = "ChartArea1";
            this.chartDistance.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDistance.Legends.Add(legend3);
            this.chartDistance.Location = new System.Drawing.Point(822, 333);
            this.chartDistance.Name = "chartDistance";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "SeriesXGyro";
            series6.ChartArea = "ChartArea1";
            series6.Enabled = false;
            series6.Legend = "Legend1";
            series6.Name = "SeriesYGyro";
            series7.ChartArea = "ChartArea1";
            series7.Enabled = false;
            series7.Legend = "Legend1";
            series7.Name = "SeriesZGyro";
            this.chartDistance.Series.Add(series5);
            this.chartDistance.Series.Add(series6);
            this.chartDistance.Series.Add(series7);
            this.chartDistance.Size = new System.Drawing.Size(417, 288);
            this.chartDistance.TabIndex = 12;
            this.chartDistance.Text = "chartDistance";
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonX.Checked = true;
            this.radioButtonX.ForeColor = System.Drawing.Color.Black;
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
            this.radioButtonY.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonY.ForeColor = System.Drawing.Color.Black;
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
            this.radioButtonZ.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonZ.ForeColor = System.Drawing.Color.Black;
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButtonX);
            this.panel1.Controls.Add(this.radioButtonZ);
            this.panel1.Controls.Add(this.radioButtonY);
            this.panel1.Location = new System.Drawing.Point(577, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 36);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "Go back to Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HealthData_Form
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartDistance);
            this.Controls.Add(this.chartHeight);
            this.Controls.Add(this.chartHeartbeat);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.labelEnvTemp);
            this.Controls.Add(this.labelBodyTemp);
            this.Controls.Add(this.labelBPM);
            this.Controls.Add(this.buttonStart);
            this.Name = "HealthData_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Button buttonStop;
        private Series series1;
        private Chart chartHeartbeat;
        private Chart chartHeight;
        private Chart chartDistance;
        private RadioButton radioButtonX;
        private RadioButton radioButtonY;
        private RadioButton radioButtonZ;
        private Panel panel1;
        private Button button1;
    }
}