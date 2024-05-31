using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    internal class Brightness : ISensorSingle
    {
        private int _brightness;


        public void vProcessSingleData(string data)
        {
            _brightness = int.Parse(data);
        }


        public int iGetBrightness()
        {
            return _brightness;
        }
    }
}
