using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BackendCS.Measurement
{
    interface ISensorSingle
    {
        void vProcessSingleData(string data);
    }

    interface ISensorMulti
    {
        void vProcessMultiData(string[] data);
    }


    internal class Measurement
    {
        private readonly IPort _port;
        private static readonly object _lock = new object();

        private readonly List<ISensorSingle> _sensorsSingle;
        private readonly List<ISensorMulti> _sensorsMulti;


        /*
        * Constructor overgive the port
        * create all sensor objects
        */
        public Measurement(IPort port)
        {
            _port = port;
            _sensorsSingle = new List<ISensorSingle>
            {
                new HeartRate(),
                new EnvironmentTemperature(),
                new Humidity(),
                new BodyTemperature(),
                new Brightness(),
            };
            _sensorsMulti = new List<ISensorMulti> 
            {
                new Motion(),
            };
        }


        public void StartMeasurement()
        {
            _port.vConnectHardware(DataReceivedHandler);
        }


        public void StopMeasurement()
        {
            _port.vDisconnectHardware();
        }


        /*
        * Handler who collect all Sensor Datas
        */
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            lock (_lock)
            {
                SerialPort serialPort = (SerialPort)sender;

                //read Datas into string
                string data = serialPort.ReadLine().Trim();

                //seperate values
                string[] aData = data.Split(',');

                vOrganizeSingleData(aData);
                vOrganizeMultiData(aData);
            }
        }
        

        /*
        * fill the single data sensors
        */
        private void vOrganizeSingleData(string[] data)
        {
            for(int i = 0; i < _sensorsSingle.Count; i++)
            {
                if(!bCheckNAN(data[i]))
                {
                    _sensorsSingle[i].vProcessSingleData(data[i]);
                }
            }
        }


        /*
        * fill the multiple data sensors
        */
        private void vOrganizeMultiData(string[] data)
        {
            for (int i = 0; i < _sensorsMulti.Count; i++)
            {
                _sensorsMulti[i].vProcessMultiData(data);
            }
        }


        /*
        * checks if there is not a number in the data
        */
        private bool bCheckNAN(string data)
        {
            if (data == "nan") return true;
            return false;
        }
    }
}
