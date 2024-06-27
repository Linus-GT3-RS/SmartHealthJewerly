using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Win32;

namespace BackendCS.Measurement
{
    public class Motion : ISensorMulti
    {
        //acceleration of the axis
        private float _accX;
        private float _accY;
        private float[] _last100accY = new float[100];
        private int idxAccY;
        private float _avgAccY;
        private float _accZ;

        //gyroscope of the axis
        private float _gyroX;
        private float _gyroY;
         private float[] _last100gyroY = new float[100];
         private int idxGyroY;
         private float _avgGyroY;
      private float _gyroZ;

        private float _lastVal;



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
                            _last100accY[idxAccY++] = result;
                            idxAccY = (idxAccY > 99) ? 0 : idxAccY;
                        break;
                        case 7:
                            _accZ = result;
                            break;
                        case 8:
                            _gyroX = result;
                            break;
                        case 9:
                            _gyroY = result;
                            _last100gyroY[idxGyroY++] = result;
                            idxGyroY = (idxGyroY > 99) ? 0 : idxGyroY;
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
         vCalculateAcc();
         return new float[] { _accX, _accY, _accZ, _gyroX, _gyroY, _gyroZ, _avgAccY, _avgGyroY };
        }


         private void vCalculateAcc()
         {
            _avgAccY = 0;
            _avgGyroY = 0;
            for(int i = 0; i < _last100accY.Length; i++)
            {
               _avgAccY += _last100accY[i];
               _avgGyroY += _last100gyroY[i];
            }
            _avgAccY /= 100;
            _avgGyroY /= 100;
            //if (_avgAccY < 0.0001) _avgAccY = 0;
         }
    }
}
