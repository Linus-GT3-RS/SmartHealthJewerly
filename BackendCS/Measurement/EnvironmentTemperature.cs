using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public class EnvironmentTemperature : ISensorSingle
    {
        private float _envTemp;


        public void vProcessSingleData(string data)
        {
            _envTemp = float.Parse(data);
        }


        public float fGetEnvTemp()
        {
            return _envTemp;
        }
    }
}
