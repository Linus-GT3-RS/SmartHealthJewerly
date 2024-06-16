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
using BackendCS.Event;
using System.Drawing.Printing;


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
            measurement.PrintData += vPrintMeasurements;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            measurement.vStopMeasurement();
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            measurement.vStartMeasurement(); //start measurement
        }

        //func gets only called, when measurement is finished receiving data
        private void vPrintMeasurements(PrintDataEventArgs printDataEventArgs)
        {
            float brightnessValue = measurement._sensorsSingle[4].fGetSingleData();
            float BrightnessPercentage = (float)Math.Round(BackendCS.Converter.BrightnessConverter.convert(brightnessValue) * 100, 1);
            float environmentTemperature = (float)Math.Round(measurement._sensorsSingle[1].fGetSingleData()*100, 1);
            float environmentHumidity = (float)Math.Round(measurement._sensorsSingle[2].fGetSingleData(), 1); //muss noch converted werden
            float bodyTemperature = (float)Math.Round(measurement._sensorsSingle[3].fGetSingleData(), 1);
            BeginInvoke((Action)(() => //switch back to main thread
            {
                labelBPM.Text = "Beats per minute: " + measurement._sensorsSingle[0].fGetSingleData().ToString();
                labelEnvTemp.Text = "Environment Temperature: " + environmentTemperature + " Grad";
                labelHumidity.Text = "Environment humidity: " + environmentHumidity + "% Luftfeuchte";
                labelBodyTemp.Text = "Body temperature: " + bodyTemperature + " Grad";
                labelBrightness.Text = "Brightness: " + brightnessValue.ToString() + " => " + BrightnessPercentage  + "% dunkel";


                //motion
                //labelMotionAccX.Text = measurement._sensorsMulti.fGetMultiData(0);
                //labelMotionAccY.Text = measurement._sensorsMulti.fGetMultiData(0);
                //labelMotionAccZ.Text = measurement._sensorsMulti.fGetMultiData(0);

            }));
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            measurement.vStopMeasurement(); //stop measurement
        }
    }
}
