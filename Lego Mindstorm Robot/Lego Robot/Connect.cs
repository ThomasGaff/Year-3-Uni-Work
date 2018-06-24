using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MonoBrick.EV3;
using System.IO.Ports;
using System.Data.Odbc;
using System.Threading.Tasks;

namespace Lego_Robot
{
    public partial class Connect : Form
    {

        private String sensorType;

        private Brick<Sensor, Sensor, Sensor, Sensor> brick;
        private TouchSensor sensorTouch;

        private IRSensor sensorDistance;
        private ColorSensor sensorColour;

        public Connect()
        {
            InitializeComponent();
        }
        public static class Globalvariable
        {
            public static string sComPort;
            public static String sensorType;

            public static Brick<Sensor, Sensor, Sensor, Sensor> brick;
            public static TouchSensor sensorTouch;

            public static IRSensor sensorDistance;
            public static ColorSensor sensorColour;
        }

        private void bttnConnnect_Click(object sender, EventArgs e)
        {
            string sCom = txtcom.Text;

            Connect.Globalvariable.sComPort = "COM" + sCom;
            
            try
            {
                // if brick is already connected then disconnect it
                if (brick != null && brick.Connection.IsConnected)
                {
                    MessageBox.Show("Robot is already connected", "Connect error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                this.Hide();
                Robot_Control Robot_Control = new Robot_Control();
                Robot_Control.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error connecting to robot on " + Connect.Globalvariable.sComPort, "Connect error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // call disconnect in case robot has already connected when error occured
            }
        }

        private void cmbConnnect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Connect_Load(object sender, EventArgs e)
        {
            //string[] ports = SerialPort.GetPortNames();
        }
    }
}
