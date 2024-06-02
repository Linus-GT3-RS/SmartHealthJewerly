﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
    public class BodyTemperature : ISensorSingle
    {
        private float _bodyTemp;


        public void vProcessSingleData(string data)
        {
            _bodyTemp = float.Parse(data);
        }


        public float fGetSingleData()
        {
            return _bodyTemp;
        }
    }
}
