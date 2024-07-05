using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace UserInterface
{
    partial class MotionData_Form
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
         System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
         this.chartHeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.chartDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.radioButtonX = new System.Windows.Forms.RadioButton();
         this.radioButtonY = new System.Windows.Forms.RadioButton();
         this.radioButtonZ = new System.Windows.Forms.RadioButton();
         this.panel1 = new System.Windows.Forms.Panel();
         this.button1 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // chartHeight
         // 
         this.chartHeight.BackColor = System.Drawing.Color.SteelBlue;
         chartArea1.Name = "ChartArea1";
         chartArea1.AxisY.Minimum = -200;
         chartArea1.AxisY.Maximum = 200;
         this.chartHeight.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         this.chartHeight.Legends.Add(legend1);
         this.chartHeight.Location = new System.Drawing.Point(628, 12);
         this.chartHeight.Name = "chartHeight";
         series1.ChartArea = "ChartArea1";
         series1.Legend = "Legend1";
         series1.Name = "SeriesXAcc";
         series2.ChartArea = "ChartArea1";
         series2.Enabled = false;
         series2.Legend = "Legend1";
         series2.Name = "SeriesYAcc";
         series3.ChartArea = "ChartArea1";
         series3.Enabled = false;
         series3.Legend = "Legend1";
         series3.Name = "SeriesZAcc";
         this.chartHeight.Series.Add(series1);
         this.chartHeight.Series.Add(series2);
         this.chartHeight.Series.Add(series3);
         this.chartHeight.Size = new System.Drawing.Size(631, 598);
         this.chartHeight.TabIndex = 11;
         this.chartHeight.Text = "chartHeight";
         // 
         // chartDistance
         // 
         this.chartDistance.BackColor = System.Drawing.Color.SteelBlue;
         chartArea2.Name = "ChartArea1";
         chartArea2.AxisY.Minimum = -200;
         chartArea2.AxisY.Maximum = 200;
         this.chartDistance.ChartAreas.Add(chartArea2);
         legend2.Name = "Legend1";
         this.chartDistance.Legends.Add(legend2);
         this.chartDistance.Location = new System.Drawing.Point(12, 12);
         this.chartDistance.Name = "chartDistance";
         series4.ChartArea = "ChartArea1";
         series4.Legend = "Legend1";
         series4.Name = "SeriesXGyro";
         series5.ChartArea = "ChartArea1";
         series5.Enabled = false;
         series5.Legend = "Legend1";
         series5.Name = "SeriesYGyro";
         series6.ChartArea = "ChartArea1";
         series6.Enabled = false;
         series6.Legend = "Legend1";
         series6.Name = "SeriesZGyro";
         this.chartDistance.Series.Add(series4);
         this.chartDistance.Series.Add(series5);
         this.chartDistance.Series.Add(series6);
         this.chartDistance.Size = new System.Drawing.Size(592, 589);
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
         this.radioButtonX.Size = new System.Drawing.Size(79, 24);
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
         this.radioButtonY.Size = new System.Drawing.Size(79, 24);
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
         this.radioButtonZ.Size = new System.Drawing.Size(78, 24);
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
         this.panel1.Location = new System.Drawing.Point(379, 616);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(486, 36);
         this.panel1.TabIndex = 16;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(12, 666);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(181, 55);
         this.button1.TabIndex = 17;
         this.button1.Text = "Go back to Home";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // MotionData_Form
         // 
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(1271, 733);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.chartDistance);
         this.Controls.Add(this.chartHeight);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "MotionData_Form";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         ((System.ComponentModel.ISupportInitialize)(this.chartHeight)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);

        }


        #endregion
        private Series series1;
        private Chart chartHeight;
        private Chart chartDistance;
        private RadioButton radioButtonX;
        private RadioButton radioButtonY;
        private RadioButton radioButtonZ;
        private Panel panel1;
        public Button button1;
   }
}