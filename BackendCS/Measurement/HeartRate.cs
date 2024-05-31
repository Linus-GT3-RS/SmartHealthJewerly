using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public class HeartRate : ISensorSingle
    {
        private int _heartRate;


        public void vProcessSingleData(string data)
        {
            _heartRate = int.Parse(data);
        }


        public int iGetHeartRate()
        {
            return _heartRate;
        }
    }
}
