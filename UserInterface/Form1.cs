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
        System.Timers.Timer timer;
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


            //timer wird genutzt um Helligkeit der GUI alle 10s zuupdaten
            timer = new System.Timers.Timer(10000); // 10 Sekunden in Millisekunden
            // Ereignis, das ausgelöst wird, wenn der Timer abläuft
            timer.Elapsed += AdjustBrightness;
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            measurement.vStopMeasurement(); //stop measurement
            timer.Stop();          // Timer stoppen
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            measurement.vStartMeasurement(); //start measurement
            timer.Start();          // Timer starten
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


        //GUI Color anpassen
        private void AdjustBrightness(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Werte holen
            float brightnessVal = measurement._sensorsSingle[4].fGetSingleData();
            int BrightnessPercentage = 100 - (int)Math.Round(BackendCS.Converter.BrightnessConverter.convert(brightnessVal) * 100, 1);


            //wird gebraucht, damit GUI nicht komplett schwarz wird => 20 % helligkeit bruacht es schon
            //falls mehr sein soll muss nur der Wert geändert werden
           if (BrightnessPercentage < 20)
           {
                BrightnessPercentage = 20;
           }


            // Umrechnung des Prozentwerts in den RGB-Bereich (0-255)
            int brightnessValue = (int)(BrightnessPercentage * 2.55); // 255 / 100 = 2.55

            // Erstellen einer neuen Farbe mit den berechneten RGB-Werten
            Color backgroundColor = Color.FromArgb(brightnessValue, brightnessValue, brightnessValue);

            // Setzen der Hintergrundfarbe des Panels (oder des Formulars)
            this.BackColor = backgroundColor;
        }
    }
}
