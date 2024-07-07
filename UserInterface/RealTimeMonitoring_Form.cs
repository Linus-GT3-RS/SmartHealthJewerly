using BackendCS.Measurement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface
{
   public partial class RealTimeMonitoring_Form : Form
   {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        HeartRate heart;
        private bool _normalRun;

      public RealTimeMonitoring_Form(bool normalRun)
      {
            _normalRun = normalRun;

         InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

      private void button1_Click(object sender, EventArgs e)
      {
         
      }


      public void vPrintMeasurements()
      {

         //nicht in invoke ausführen, da der GUI Thread das berechnen sonst übernimmt

         heart = (HeartRate)GlobalMeasurement.measurement._sensorsSingle[0];


         BeginInvoke((Action)(() => //switch back to main thread
         {
            lblBPM.Text = "Beats per minute: " + heart.fGetSingleData();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(_normalRun)
            {
                this.Hide();
            }
            else { this.Close(); }
        }


        public void SetBrooch_Good()
        {
            pctboxBrooch.Image = global::UserInterface.Properties.Resources.Good;
        }

        public void SetBrooch_Ok()
        {
            pctboxBrooch.Image = global::UserInterface.Properties.Resources.Ok1;
        }

        public void SetBrooch_Danger()
        {
            pctboxBrooch.Image = global::UserInterface.Properties.Resources.Danger;
        }
    }
}

