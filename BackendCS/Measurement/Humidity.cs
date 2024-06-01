using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public class Humidity : ISensorSingle
    {
        private float _humidity;


        public void vProcessSingleData(string data)
        {
            _humidity = float.Parse(data);
        }


        public float fGetSingleData()
        {
            return _humidity;
        }
    }
}
