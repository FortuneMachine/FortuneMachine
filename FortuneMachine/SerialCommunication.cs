using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneMachine
{
    class SerialCommunication
    {
        private string _port;
        private double _baudRate;
        private int _stopBits;
        private int _parityBits;
        private int _dataBits;

        public void Print(string text)
        {

        }

        public DateTime GetDate()
        {
            return new DateTime();
        }

        public float[] GetPosition()
        {
            return new float[1];
        }    
    }
}
