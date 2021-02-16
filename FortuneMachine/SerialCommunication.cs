using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FortuneMachine
{
    class SerialCommunication
    {
        private const string PORT_COM = "/dev/serial0";
        private const int BAUD_RATE = 57600;
        private const Parity PARITY = Parity.None;
        private const int DATA_BITS = 8;
        private const StopBits STOP_BITS = StopBits.One;
        private SerialPort mySerialPort;

        public SerialCommunication()
        {
            mySerialPort = new SerialPort
            {
                PortName = PORT_COM,
                BaudRate = BAUD_RATE,
                DataBits = DATA_BITS,
                Parity = PARITY,
                StopBits = STOP_BITS
            };
            try
            {
                Console.WriteLine("Ouverture du port");
                mySerialPort.Open();

                Console.WriteLine("Lancement du thread");
                Thread th = new Thread(Read);
                th.IsBackground = true;
                th.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }

        private void Read()
        {
            string received = "";
            while (true)
            {
                received = mySerialPort.ReadExisting();
                if (received != "")
                {
                    Console.WriteLine("Reçu : " + received);
                    received = "";
                }
                Thread.Sleep(100);
            }
        }

        public void Print(string text)
        {
            char carriageReturn = (char)0x0A;
            string toSend = "<PRN:" + text + carriageReturn.ToString();
            mySerialPort.Write(toSend);
            Console.WriteLine("Envoyé : " + toSend);
        }

        public DateTime GetDate()
        {
            char carriageReturn = (char)0x0A;
            string toSend = "<GDT?" + carriageReturn.ToString();
            mySerialPort.Write(toSend);
            Console.WriteLine("Envoyé : " + toSend);
            return new DateTime();
        }

        public float[] GetPosition()
        {
            char carriageReturn = (char)0x0A;
            string toSend = "<GPS?" + carriageReturn.ToString();
            mySerialPort.Write(toSend);
            Console.WriteLine("Envoyé : " + toSend);
            return new float[1];
        }    
    }
}
