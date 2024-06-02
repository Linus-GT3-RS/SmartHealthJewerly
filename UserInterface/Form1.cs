using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendCS.Measurement;



namespace UserInterface
{
    public partial class Form1 : Form
    {
        private Measurement measurement;
        bool bStop = false;


        public Form1()
        {
            InitializeComponent();

            measurement = new Measurement();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            measurement.vStopMeasurement();
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            measurement.vStartMeasurement();

            while(!bStop)
            {
                vPrintMeasurements();
            }

            measurement.vStopMeasurement();
        }


        private void vPrintMeasurements()
        {
            labelBPM.Text = "Beats per minute: " + measurement._sensorsSingle[0].fGetSingleData().ToString();
            labelEnvTemp.Text = "Environment Temperature: " + measurement._sensorsSingle[1].fGetSingleData().ToString();
            labelHumidity.Text = "Environment humidity: " + measurement._sensorsSingle[2].fGetSingleData().ToString();
            labelBodyTemp.Text = "Body temperature: " + measurement._sensorsSingle[3].fGetSingleData().ToString();
            labelBrightness.Text = "Brightness: " + measurement._sensorsSingle[4].fGetSingleData().ToString();
            

        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            bStop = true;
        }
    }
}
