using BackendCS.Measurement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface
{
   public partial class HeartRate_Form : Form
   {
      HeartRate heart;
      public HeartRate_Form()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.Hide();
      }


      public void vPrintMeasurements()
      {

         //nicht in invoke ausführen, da der GUI Thread das berechnen sonst übernimmt

         heart = (HeartRate)GlobalMeasurement.measurement._sensorsSingle[0];


         BeginInvoke((Action)(() => //switch back to main thread
         {
            labelBPM.Text = "Beats per minute: " + heart.fGetSingleData();
            //fillSeries
            fillSeries();
            //redraw charts
            redrawCharts();
         }));
      }
      private void fillSeries()
      {
         Series heartBeat = chartHeartbeat.Series["Series1"];
         if (heartBeat.Points.Count > 500)
         {
            heartBeat.Points.RemoveAt(0); // Keep the number of points reasonable
         }

         heartBeat.Points.AddY(heart.iGetHeartRate());
      }

      private void redrawCharts()
      {
         chartHeartbeat.Invalidate();
      }
   }
}

