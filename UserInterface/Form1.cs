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

using System.Windows.Forms;
using System.IO.Ports;

using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;

namespace GUI_Toto
{
   public partial class Form1 : Form
   {
      private bool handleCreated = false;


      private SerialPort serialPort;
      private static readonly object _lock = new object();
      static int heartRateBPM = 0;
      static int counter = 0;
      int HerzschlagCounter = 0;
      static int beatMsec = 0;
      const int delayMsec = 60;
      static int maxValue = 0;
      static bool isPeak = false;




      public Form1()
      {
         InitializeComponent();

         //test funktion fürs plotten
         //Create a new thread and specify the method to be executed
         Thread newThread = new Thread(new ThreadStart(testfuncPlotting));

         // Start the thread
         //newThread.Start();

         Series series = chart1.Series["HeartRate"];
         if (series.Points.Count > 100)
         {
            series.Points.RemoveAt(0); // Keep the number of points reasonable
         }

         series.Points.AddY(700);
         chart1.Invalidate(); // Redraw the chart


         // The main thread continues execution independently of the new thread
         Console.WriteLine("Main thread is still running.");

         // Optionally, wait for the new thread to finish


      }



      public void testfuncPlotting()
      {
         while (true)
         {
            lock (_lock)
            {
               Series series = chart1.Series["HeartRate"];
               if (series.Points.Count > 100)
               {
                  series.Points.RemoveAt(0); // Keep the number of points reasonable
               }
               Random random = new Random();

               // Generate a random integer between 600 and 800
               int randomNumber = random.Next(600, 801);
               this.Invoke(new MethodInvoker(delegate
               {
                  series.Points.AddY(randomNumber);
                  chart1.Invalidate(); // Redraw the chart
               }));

               Thread.Sleep(10);
            }

         }

      }


      private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
      {

         lock (_lock)
         {
            // Casten des Senders zurück zu SerialPort
            SerialPort serialPort = (SerialPort)sender;

            // Daten lesen und auf der Konsole anzeigen
            string data = serialPort.ReadLine().Trim();

            // Daten in einzelne Werte trennen (CSV)
            string[] values = data.Split(',');
            if (values.Length >= 4)
            {

               int spannungVomHerzschlagSensor = int.Parse(values[0]);
               //herzschlagfunktionalität
               if (HerzschlagCounter >= 6)
               {
                  Herzschlag(spannungVomHerzschlagSensor);
                  HerzschlagCounter = 0;
                  Series series = chart1.Series["HeartRate"];
                  if (series.Points.Count > 100)
                  {
                     series.Points.RemoveAt(0); // Keep the number of points reasonable
                  }

                  series.Points.AddY(spannungVomHerzschlagSensor);
                  chart1.Invalidate(); // Redraw the chart
               }
               HerzschlagCounter++;
               // Invoke UI updates on the main thread
               this.Invoke(new MethodInvoker(delegate
               {
                  BPMLabel.Text = heartRateBPM + " BPM";
                  HerzschlagSpannungsLabel.Text = spannungVomHerzschlagSensor + "";

                  if (values[2] != "nan")
                  {
                     float luftfeuchtigkeitInProzent = float.Parse(values[2]);
                     luftfeuchtigkeitsLabel.Text = luftfeuchtigkeitInProzent + "% Luftfeuchtigkeit";
                  }

                  if (values[1] != "nan")
                  {
                     float WaermeInGradCelcius = float.Parse(values[1]);
                     temperaturLabel.Text = WaermeInGradCelcius + "";
                  }

                  if (values[3] != "nan")
                  {
                     float KoerperTemperaturInGradCelcius = float.Parse(values[3]);
                     KoerperTemperaturLabel.Text = KoerperTemperaturInGradCelcius + "";
                  }
               }));
            }
         }
      }



      private void initializeSerialPort()
      {
         serialPort = new SerialPort("COM4", 115200); // Ändern Sie COM3 entsprechend dem Anschluss des Arduinos
         serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

         try
         {
            serialPort.Open();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Fehler beim Öffnen der seriellen Verbindung: " + ex.Message);
         }
      }


      //event wird getriggert, wenn apllication geschlossen wird => serialport schließen
      private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         // Schließe die serielle Verbindung, wenn das Formular geschlossen wird
         if (serialPort.IsOpen)
         {
            serialPort.Close();
         }
      }



      public void Herzschlag(int Spannung)
      {
         if (heartbeatDetected(delayMsec, Spannung))
         {
            if (beatMsec != 0)
            {
               heartRateBPM = 60000 / beatMsec;
            }


            beatMsec = 0;
         }
         beatMsec += delayMsec;

         //dully.Text = getDurchschnittLast20Spannungen() + "";
         //HerzschlagCounter++;
      }



      bool heartbeatDetected(int delay, int rawValue)
      {

         bool result = false;

         // Here the current voltage value at the photo transistor is read out and stored temporarily in the rawValue variable
         rawValue *= (1000 / delay);

         // Should the current value deviate too far from the last maximum value
         // (e.g. because the finger was put on again or taken away)
         // So the MaxValue is reset to get a new base.
         if (rawValue * 4L < maxValue)
         {
            maxValue = (int)(rawValue * 0.8);
         } // Detect new peak
         if (rawValue > maxValue - (1000 / delay))
         {
            // The actual peak is detected here. Should a new RawValue be bigger
            // as the last maximum value, it will be recognized as the top of the recorded data.
            if (rawValue > maxValue)
            {
               maxValue = rawValue;
            }
            // Only one heartbeat should be assigned to the recognized peak
            if (isPeak == false)
            {
               result = true;
            }
            isPeak = true;
         }
         else if (rawValue < maxValue - (3000 / delay))
         {
            isPeak = false;
            // This is the maximum value for each pass
            // slightly reduced again. The reason for this is that
            // not only the value is otherwise always stable with every stroke
            // would be the same or smaller, but also,
            // if the finger should move minimally and thus
            // the signal would generally become weaker.
            maxValue -= (1000 / delay);
         }
         return result;
      }

   }
}
