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
using System.Windows.Forms.DataVisualization.Charting;


namespace UserInterface
{
    public partial class HealthData_Form : Form
    {
        private Measurement measurement;
        bool bStop = false;
        System.Timers.Timer timer;
        HeartRate heart;
        Motion motion;
        float _currentHeight;
        private static readonly object _lock = new object(); 
        private bool _normalRun;
        
        public HealthData_Form(bool normalRun)
        {
            _normalRun = normalRun;

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
            measurement.PrintData += vPrintMeasurements;                    //event hinterlegen
            buttonStart.Enabled = true;                                     //ab jetzt kann gemessen werden


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
         lock (_lock)
         {
            //nicht in invoke ausführen, da der GUI Thread das berechnen sonst übernimmt
            float brightnessValue = measurement._sensorsSingle[4].fGetSingleData();
            float BrightnessPercentage = (float)Math.Round(BackendCS.Converter.BrightnessConverter.convert(brightnessValue) * 100, 1);
            float environmentTemperature = measurement._sensorsSingle[1].fGetSingleData();
            float environmentHumidity = measurement._sensorsSingle[2].fGetSingleData();
            float bodyTemperature = measurement._sensorsSingle[3].fGetSingleData();
            heart = (HeartRate)measurement._sensorsSingle[0];
            motion = (Motion)measurement._sensorsMulti[0];
            float[] motionValues = motion.fGetMultiData();
            //if (motionValues[7] < 0)
            //{
            //   _currentHeight -= motionValues[6];
            //}
            //else
            //{
            //   _currentHeight += motionValues[6];
            //}
            _currentHeight = motionValues[6];
            BeginInvoke((Action)(() => //switch back to main thread
                  {
                     labelBPM.Text = "Beats per minute: " + heart.fGetSingleData();
                     labelEnvTemp.Text = "Environment Temperature: " + environmentTemperature.ToString("F1") + " Grad";
                     labelHumidity.Text = "Environment humidity: " + environmentHumidity.ToString("F1") + "% Luftfeuchte";
                     labelBodyTemp.Text = "Body temperature: " + bodyTemperature.ToString("F1") + " Grad";
                     labelBrightness.Text = "Brightness: " + brightnessValue.ToString() + " => " + BrightnessPercentage + "% dunkel";


                     //motion
                     labelMotionAccX.Text = measurement._sensorsMulti[0].fGetMultiData()[6] + "";
                     labelMotionAccY.Text = measurement._sensorsMulti[0].fGetMultiData()[7] + "";
                     labelMotionAccZ.Text = measurement._sensorsMulti[0].fGetMultiData()[2] + "";


                     //fillSeries
                     fillSeries();

                     //redraw charts
                     redrawCharts();
                    
                     }));
         }
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

        private void radioButtonX_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonX.Checked)
            {
                chartHeight.Series["SeriesXAcc"].Enabled = true;
                chartDistance.Series["SeriesXGyro"].Enabled = true;
            }
            else
            {
                chartHeight.Series["SeriesXAcc"].Enabled = false;
                chartDistance.Series["SeriesXGyro"].Enabled = false;
            }
        }

        private void radioButtonY_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonY.Checked)
            {
                chartHeight.Series["SeriesYAcc"].Enabled = true;
                chartDistance.Series["SeriesYGyro"].Enabled = true;
            }
            else
            {
                chartHeight.Series["SeriesYAcc"].Enabled = false;
                chartDistance.Series["SeriesYGyro"].Enabled = false;
            }
        }

        private void radioButtonZ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZ.Checked)
            {
                chartHeight.Series["SeriesZAcc"].Enabled = true;
                chartDistance.Series["SeriesZGyro"].Enabled = true;
            }
            else
            {
                chartHeight.Series["SeriesZAcc"].Enabled = false;
                chartDistance.Series["SeriesZGyro"].Enabled = false;
            }
        }



        private void fillSeries()
        {
            Series heartBeat = chartHeartbeat.Series["Series1"];
            if (heartBeat.Points.Count > 500)
            {
            heartBeat.Points.RemoveAt(0); // Keep the number of points reasonable
            }

            heartBeat.Points.AddY(heart.iGetHeartRate());

            fillXAxis();
            fillYAxis();
            fillZAxis();
        }

        private void fillXAxis()
        {
            motion = (Motion)measurement._sensorsMulti[0];
            float[] motionValues = motion.fGetMultiData();
            Series XAcc = chartHeight.Series["SeriesXAcc"];
            if (XAcc.Points.Count > 500)
            {
            XAcc.Points.RemoveAt(0); // Keep the number of points reasonable
            }
            XAcc.Points.AddY(motionValues[0]);


            Series XGyro = chartDistance.Series["SeriesXGyro"];
            if (XGyro.Points.Count > 500)
            {
            XGyro.Points.RemoveAt(0); // Keep the number of points reasonable
            }
            XGyro.Points.AddY(motionValues[6]);
        }
        private void fillYAxis()
        {
            Series YAcc = chartHeight.Series["SeriesYAcc"];
            if (YAcc.Points.Count > 500)
            {
            YAcc.Points.RemoveAt(0); // Keep the number of points reasonable
            }
            YAcc.Points.AddY(20);


            Series YGyro = chartDistance.Series["SeriesYGyro"];
            if (YGyro.Points.Count > 500)
            {
            YGyro.Points.RemoveAt(0); // Keep the number of points reasonable
            }
            YGyro.Points.AddY(200);
        }
        private void fillZAxis()
        {
            Series ZAcc = chartHeight.Series["SeriesZAcc"];
            if (ZAcc.Points.Count > 500)
            {
            ZAcc.Points.RemoveAt(0); // Keep the number of points reasonable
            }
            ZAcc.Points.AddY(30);


            Series ZGyro = chartDistance.Series["SeriesZGyro"];
            if (ZGyro.Points.Count > 500)
            {
            ZGyro.Points.RemoveAt(0); // Keep the number of points reasonable
            }
            ZGyro.Points.AddY(300);
        }


        private void redrawCharts()
        {
            chartHeartbeat.Invalidate();
            chartHeight.Invalidate();
            chartDistance.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_normalRun) 
            {
                this.Hide();
            }          
        }
    }
}
