using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
            if (float.TryParse(data[5], NumberStyles.Float, CultureInfo.InvariantCulture, out float result1))
            {
                _accX = float.Parse(data[5]);
            }
            if (float.TryParse(data[6], NumberStyles.Float, CultureInfo.InvariantCulture, out float result2))
            {
                _accY = float.Parse(data[6]);
            }
            if (float.TryParse(data[7], NumberStyles.Float, CultureInfo.InvariantCulture, out float result3))
            {
                _accZ = float.Parse(data[7]);
            }
            if (float.TryParse(data[8], NumberStyles.Float, CultureInfo.InvariantCulture, out float result4))
            {
                _gyroX = float.Parse(data[8]);
            }
            if (float.TryParse(data[9], NumberStyles.Float, CultureInfo.InvariantCulture, out float result5))
            {
                _gyroY = float.Parse(data[9]);
            }
            if (float.TryParse(data[10], NumberStyles.Float, CultureInfo.InvariantCulture, out float result6))
            {
                _gyroZ = float.Parse(data[10]);
            }

        }


        public float[] fGetMultiData()
        {
            return new float[] { _accX, _accY, _accZ, _gyroX, _gyroY, _gyroZ };
        }
    }
}
