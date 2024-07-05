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
   public partial class EnvironmentData_Form : Form
   {


      System.Timers.Timer timer;

      public EnvironmentData_Form()
      {
         InitializeComponent();
         //timer wird genutzt um Helligkeit der GUI alle 10s zuupdaten
         timer = new System.Timers.Timer(10000); // 10 Sekunden in Millisekunden
         timer.Elapsed += AdjustBrightness; // Ereignis, das ausgelöst wird, wenn der Timer abläuft
         timer.Start();
      }


      public void vPrintMeasurements()
      {

         //nicht in invoke ausführen, da der GUI Thread das berechnen sonst übernimmt
         float brightnessValue = GlobalMeasurement.measurement._sensorsSingle[4].fGetSingleData();
         float BrightnessPercentage = (float)Math.Round(BackendCS.Converter.BrightnessConverter.convert(brightnessValue) * 100, 1);
         float environmentTemperature = GlobalMeasurement.measurement._sensorsSingle[1].fGetSingleData();
         float environmentHumidity = GlobalMeasurement.measurement._sensorsSingle[2].fGetSingleData();
         float bodyTemperature = GlobalMeasurement.measurement._sensorsSingle[3].fGetSingleData();
         


         BeginInvoke((Action)(() => //switch back to main thread
         {
            labelEnvTemp.Text = "Environment Temperature: " + environmentTemperature.ToString("F1") + " Grad";
            labelHumidity.Text = "Environment humidity: " + environmentHumidity.ToString("F1") + "% Luftfeuchte";
            label4.Text = "Body temperature: " + bodyTemperature.ToString("F1") + " Grad";
            labelBrightness.Text = "Brightness: " + brightnessValue.ToString() + " => " + BrightnessPercentage + "% dunkel";

         }));

      }


      //GUI Color anpassen
      private void AdjustBrightness(object sender, System.Timers.ElapsedEventArgs e)
      {
         //Werte holen
         float brightnessVal = GlobalMeasurement.measurement._sensorsSingle[4].fGetSingleData();
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
