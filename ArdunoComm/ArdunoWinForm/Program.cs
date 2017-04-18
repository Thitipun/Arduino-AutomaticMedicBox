using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace ArdunoWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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
        public void Open()
        {
            currentPort.Open();
        }
        public void Close()
        {
            currentPort.Close();
        }
        public void Write(string data)
        {
            currentPort.Write(data);
        }
       

        //public void Run()
        //{
        //    currentPort.Open();
        //    int j = 20;
        //    while (j > 0)
        //    {
        //        if ((j % 2) == 0)
        //        {
        //            currentPort.Write("0");
        //        }
        //        else
        //        {
        //            currentPort.Write("1");
        //        }
        //        Thread.Sleep(1000);
        //        j--;
        //    }
        //    currentPort.Close();
        //}

    }
}
