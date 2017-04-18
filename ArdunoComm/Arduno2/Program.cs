using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.IO;


namespace Arduno2
{
    class Program
    {
        static void Main(string[] args)
        {
            //start here
            ArduinoControllerApp app = new ArduinoControllerApp();
            app.SetComPort();
            app.Run();
        }
    }

    public class ArduinoControllerApp
    {

        SerialPort currentPort;
        public void SetComPort()
        {

            string[] ports = SerialPort.GetPortNames();
            //for test only:
            //hardcode: we select 1st port as arduno port
            if (ports.Length == 0)
            {
                return;
            }
            //----------------------------------------- 
            //
            currentPort = new SerialPort(ports[0], 9600); 
        }

        public void Run()
        {
            currentPort.Open();
            int j = 20;
            while (j > 0)
            {
                if ((j % 2) == 0)
                {
                    currentPort.Write("0");
                }
                else
                {
                    currentPort.Write("1");
                }
                Thread.Sleep(1000);
                j--;
            }
            currentPort.Close();
        }

    }
}
