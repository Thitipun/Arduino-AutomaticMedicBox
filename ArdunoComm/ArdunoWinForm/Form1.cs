using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArdunoWinForm
{
    public partial class Form1 : Form
    {
        ArduinoControllerApp ardunoApp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            ardunoApp = new ArduinoControllerApp();
            ardunoApp.SetComPort();
            ardunoApp.Open();
            
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ardunoApp != null)
            {

                //close app (close all LED)
                ardunoApp.Write("2");
                ardunoApp.Close();
                ardunoApp = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ardunoApp.Write("0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ardunoApp.Write("1");
        }
    }
}
