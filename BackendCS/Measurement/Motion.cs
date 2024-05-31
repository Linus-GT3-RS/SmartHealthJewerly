using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public class Motion : ISensorMulti
    {
        //acceleration of the axis
        private float _accX;
        private float _accY;
        private float _accZ;

        //gyroscope of the axis
        private float _gyroX;
        private float _gyroY;
        private float _gyroZ;


        public void vProcessMultiData(string[] data)
        {
            _accX = float.Parse(data[5]);
            _accY = float.Parse(data[6]);
            _accZ = float.Parse(data[7]);

            _gyroX = float.Parse(data[8]);
            _gyroY = float.Parse(data[9]);
            _gyroZ = float.Parse(data[10]);
        }


        public float[] fGetAccMotion()
        {
            return new float[] { _accX, _accY, _accZ };
        }


        public float[] fGetGyroMotion()
        {
            return new float[] { _gyroX, _gyroY, _gyroZ };
        }
    }
}
