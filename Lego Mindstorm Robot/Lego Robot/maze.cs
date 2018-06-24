using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MonoBrick.EV3;

namespace Lego_Robot
{
    public partial class maze : Form
    {
        private String sensorType;

        private Brick<Sensor, Sensor, Sensor, Sensor> brick;
        private TouchSensor sensorTouch;

        private IRSensor sensorDistance;
        private ColorSensor sensorColour;

        public maze()
        {
            InitializeComponent();
        }

        private void advanced_Load(object sender, EventArgs e)
        {
            // update form with brick details
            lblConnnection.Text = "Connected to EV3 Robot";

            // Create an IR sensor and connect it to port 4
            Connect.Globalvariable.sensorDistance = new IRSensor();
            Connect.Globalvariable.brick.Sensor4 = Connect.Globalvariable.sensorDistance;

            // Create a colour sensor and connect it to port 3
            Connect.Globalvariable.sensorColour = new ColorSensor();
            Connect.Globalvariable.brick.Sensor3 = Connect.Globalvariable.sensorColour;

            // Set ports for synchronised motor vehicle
            Connect.Globalvariable.brick.Vehicle.LeftPort = MotorPort.OutB;
            Connect.Globalvariable.brick.Vehicle.RightPort = MotorPort.OutC;

            //Create touch sensor and connect it to port 2
            Connect.Globalvariable.sensorTouch = new TouchSensor();
            Connect.Globalvariable.brick.Sensor2 = Connect.Globalvariable.sensorTouch;
        }

        private void bttnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Robot_Control Robot_Control = new Robot_Control();
            Robot_Control.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Robot_Control Robot_Control = new Robot_Control();
            Robot_Control.ShowDialog();
        }

        private void defenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            defender defender = new defender();
            defender.ShowDialog();
        }

        private void rockPaperScissorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            rock rock = new rock();
            rock.ShowDialog();
        }
    }
}
