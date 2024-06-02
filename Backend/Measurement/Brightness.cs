using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public class Brightness : ISensorSingle
    {
        private int _brightness;


        public void vProcessSingleData(string data)
        {
            _brightness = int.Parse(data);
        }


        public float fGetSingleData()
        {
            return (float)_brightness;
        }
    }
}
