﻿using System;
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
            this.Load += new EventHandler(FurtherInitialization); //form fertig geladen, dann weiter initialisieren
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            measurement.vStopMeasurement();
        }

        //Rest der (Backend)-Initialisation
        private void FurtherInitialization(object sender, EventArgs e)
        {
            measurement = new Measurement();                
            measurement.PrintData += vPrintMeasurements;    //event hinterlegen
            buttonStart.Enabled = true;                     //ab jetzt kann gemessen werden
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {
            measurement.vStartMeasurement(); //start measurement
        }

        //func gets only called, when measurement is finished receiving data
        private void vPrintMeasurements(PrintDataEventArgs printDataEventArgs)
        {
            //nicht in invoke ausführen, da der GUI Thread das berechnen sonst übernimmt
            float brightnessValue = measurement._sensorsSingle[4].fGetSingleData();
            float BrightnessPercentage = (float)Math.Round(BackendCS.Converter.BrightnessConverter.convert(brightnessValue) * 100, 1);
            float environmentTemperature = measurement._sensorsSingle[1].fGetSingleData();
            float environmentHumidity = measurement._sensorsSingle[2].fGetSingleData();
            float bodyTemperature = measurement._sensorsSingle[3].fGetSingleData();
            float BPM = measurement._sensorsSingle[0].fGetSingleData();

            BeginInvoke((Action)(() => //switch back to main thread
            {
                labelBPM.Text = "Beats per minute: " + BPM;
                labelEnvTemp.Text = "Environment Temperature: " + environmentTemperature.ToString("F1") + " Grad";
                labelHumidity.Text = "Environment humidity: " + environmentHumidity.ToString("F1") + "% Luftfeuchte";
                labelBodyTemp.Text = "Body temperature: " + bodyTemperature.ToString("F1") + " Grad";
                labelBrightness.Text = "Brightness: " + brightnessValue.ToString() + " => " + BrightnessPercentage + "% dunkel";


                //motion
                labelMotionAccX.Text = measurement._sensorsMulti[0].fGetMultiData()[0] + "";
                labelMotionAccY.Text = measurement._sensorsMulti[0].fGetMultiData()[1] + "";
                labelMotionAccZ.Text = measurement._sensorsMulti[0].fGetMultiData()[2] + "";

            }));
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            measurement.vStopMeasurement(); //stop measurement
        }
    }
}
