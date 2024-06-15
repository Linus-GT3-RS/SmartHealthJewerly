using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Event
{
    internal class PrintDataEvent
    {
        public delegate void PrinDataHandler(PrintDataEventArgs e);

        public event PrinDataHandler printData; // callback Function



    }

    public class PrintDataEventArgs
    {
        public string Message { get; private set; }

        public PrintDataEventArgs(string message)
        {
            Message = message;
        }
    }
}
