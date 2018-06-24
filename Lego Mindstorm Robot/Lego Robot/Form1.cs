#define EV3

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



namespace Lego_Robot
{
    public partial class Robot_Control : Form
    {
        private String sensorType;

        private Brick<Sensor, Sensor, Sensor, Sensor> brick;
        private TouchSensor sensorTouch;

        private IRSensor sensorDistance;
        private ColorSensor sensorColour;



        public Robot_Control()
        {
            InitializeComponent();
            
        }

       
        private void Robot_Control_Load(object sender, EventArgs e)
        {
            // create brick object and connect it to robot
            brick = new Brick<Sensor, Sensor, Sensor, Sensor>(Connect.Globalvariable.sComPort);
            brick.Connection.Open();

            brick.PlayTone(100, 329, 100); //E
            Thread.Sleep(200);
            brick.PlayTone(100, 246, 100); //B
            Thread.Sleep(100);
            brick.PlayTone(100, 261, 100); //C
            Thread.Sleep(100);
            brick.PlayTone(100, 293, 100); //D

            

            // Create touch sensor and connect it to port 2
            sensorTouch = new TouchSensor();
            brick.Sensor2 = sensorTouch;
            // update form with brick details
            lblConnnection.Text = "Connected to EV3 Robot";

            // Create an IR sensor and connect it to port 4
            sensorDistance = new IRSensor();
            brick.Sensor4 = sensorDistance;

            // Create a colour sensor and connect it to port 3
            sensorColour = new ColorSensor();
            brick.Sensor3 = sensorColour;

            // Set ports for synchronised motor vehicle
            brick.Vehicle.LeftPort = MotorPort.OutB;
            brick.Vehicle.RightPort = MotorPort.OutC;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bttnA_Click(object sender, EventArgs e)
        {
            this.Hide();
            maze advanced = new maze();
            advanced.ShowDialog();
        }

        private void bttnF_Click(object sender, EventArgs e)
        {
            brick.Vehicle.Forward(20);
        }

        private void bttnL_Click(object sender, EventArgs e)
        {
            brick.Vehicle.SpinLeft(20);
        }

        private void bttnR_Click(object sender, EventArgs e)
        {
            brick.Vehicle.SpinRight(20);
        }

        private void bttnB_Click(object sender, EventArgs e)
        {
            brick.Vehicle.Backward(20);
        }

        private void bttnE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblConnnection_Click(object sender, EventArgs e)
        {

        }

        private void bttnR_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Robot_Control_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Robot_Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
            {
               brick.Vehicle.Forward(50);
               
            }
            else if (e.KeyData == Keys.S)
            {
               brick.Vehicle.Backward(50);
            }
            else if (e.KeyData == Keys.A)
            {
                brick.Vehicle.SpinLeft(50);
            }
            else if (e.KeyData == Keys.D)
            {
                brick.Vehicle.SpinRight(50);
            }
            else if(e.KeyData == Keys.E)
            {
                brick.Vehicle.Off();
            }

        }

        private void bttnStop_Click(object sender, EventArgs e)
        {
            brick.Vehicle.Off();
            
        }

        private void mazeRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            maze maze = new maze();
            maze.ShowDialog();
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
