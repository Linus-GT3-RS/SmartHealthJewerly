using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Bson;

namespace BackendCS.Event
{
    class CriticalHeartRateEvent
    {
        public delegate void CriticalHeartRateHandler(CriticalHeartRateEventArgs e);

        public event CriticalHeartRateHandler CriticialHeartRate; // callback Function

        public CriticalHeartRateEvent()
        {
            CriticialHeartRate += CriticialHeartRate;
        }

        //check heartrate wheter is critical
        // good rates are between 60 and 120
        void Check(int heartrate)
        {

            if (heartrate <= 60 || heartrate >= 120)
            {
                if (CriticialHeartRate != null)
                {
                    CriticialHeartRate(new CriticalHeartRateEventArgs("Kritischer Wert wurde überschritten:"));
                }
            }

        }


        // Eventhandler, send a notification to all contactperson of a patient
        void CriticalHeartHandler(object sender, CriticalHeartRateEventArgs e)
        {
            Console.WriteLine("Event fired");
            Backend.Instance().GetProfile().GetPatient().NotifyContacts(e.ToString());
        }
    }

    public class CriticalHeartRateEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public CriticalHeartRateEventArgs(string message)
        {
            Message = message;
        }
    }
}
