using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using System.Timers;
using System.Windows;

namespace HostComputer
{
    public class SerialInterface
    {
        public SerialPort serialport1;
        public SerialPort serialport2;
        public static double anglex = 0.0;
        public static double angley = 0.0;
        public static double anglez = 0.0;
        public static double carx = 0.0;
        public static double cary = 0.0;
        public System.Timers.Timer timer;
        public static byte button = 0;

        public void InitialPort()
        {
            serialport1 = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            serialport2 = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
            serialport1.ReadTimeout = 500;
            serialport2.ReadTimeout = 500;
        }
        public void SendCommandToSerial(object source, System.Timers.ElapsedEventArgs e)
        {

            try
            {
                byte[] senddata = new byte[4] { 170, 85, 175, 1 };
                if (!serialport2.IsOpen)
                {
                    if (serialport1.IsOpen)
                    {
                        serialport1.Write(senddata, 0, 4);
                    }
                }

                if (!serialport1.IsOpen)
                {
                    if (serialport2.IsOpen)
                    {
                        serialport2.Write(senddata, 0, 4);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


    }

}
