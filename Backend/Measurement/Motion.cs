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
            //for Schleife Schützt for Index out of Bounds
            for (int index = 5; index < data.Length; index++)
            {
                //schützt for falschen Strings bei parsen
                if (float.TryParse(data[index], NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
                {
                    switch (index)
                    {
                        case 5:
                            _accX = result;
                            break;
                        case 6:
                            _accY = result;
                            break;
                        case 7:
                            _accZ = result;
                            break;
                        case 8:
                            _gyroX = result;
                            break;
                        case 9:
                            _gyroY = result;
                            break;
                        case 10:
                            _gyroZ = result;
                            break;
                    }
                }
            }
        }


        public float[] fGetMultiData()
        {
            return new float[] { _accX, _accY, _accZ, _gyroX, _gyroY, _gyroZ };
        }
    }
}
