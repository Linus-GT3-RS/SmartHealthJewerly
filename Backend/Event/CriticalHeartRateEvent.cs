using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Event
{
    internal class CriticalHeartRateEvent
    {
        public delegate void CriticalHeartRateHandler(CriticalHeartRateEventArgs e);

        public event CriticalHeartRateHandler CriticialHeartRate; // callback Function

        public void Check(int i)
        {
            // logic of checking heartrate

            if (CriticialHeartRate != null)
            {
                // löst Event aus
                CriticialHeartRate(new CriticalHeartRateEventArgs("kritischer Wert wurde überschritten"));
            }
        }
    }

    public class CriticalHeartRateEventArgs
    {
        public string Message { get; private set; }

        public CriticalHeartRateEventArgs(string message)
        {
            Message = message;
        }
    }
}
