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
    public partial class rock : Form
    {
        private String sensorType;

        private Brick<Sensor, Sensor, Sensor, Sensor> brick;
        private TouchSensor sensorTouch;

        private IRSensor sensorDistance;
        private ColorSensor sensorColour;

        public rock()
        {
            InitializeComponent();
        }

        private void rock_Load(object sender, EventArgs e)
        {
            // create brick object and connect it to robot
            brick = new Brick<Sensor, Sensor, Sensor, Sensor>(Connect.Globalvariable.sComPort);
            //brick.Connection.Open();

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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Robot_Control Robot_Control = new Robot_Control();
            Robot_Control.ShowDialog();
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
        public static class GlobalVariable
        {
            public static int iWin = 0;
            public static int iLoss = 0;
            public static int iTie = 0;
            
        }
        private void bttnplay_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rps = rnd.Next(1, 4);
            int rpsU = rnd.Next(1, 4);
            
            //lblResult.Text = rps.ToString();
            //lblUResult.Text = rpsU.ToString();
            // 1 = Rock 2 = Paper 3 = Scissors

            if (rps  == 1)
            {
                lblResult.Text = ("Rock");
                if (rpsU == 1)
                {
                    lblUResult.Text = ("Rock");
                    lblOut.Text = "PUPP3R also chose rock. It is a tie";
                    rock.GlobalVariable.iTie ++;
                    lblTieR.Text = rock.GlobalVariable.iTie.ToString();
                }
                else if (rpsU == 2)
                {
                    lblUResult.Text = ("Paper");
                    lblOut.Text = ("PUPP3R chose rock. You won!");
                    rock.GlobalVariable.iWin++;
                    lblWinR.Text = rock.GlobalVariable.iWin.ToString();

                }
                else if (rpsU == 3)
                {
                    lblUResult.Text = ("Scissors");
                    lblOut.Text = ("PUPP3R chose rock. You lost!");
                    rock.GlobalVariable.iLoss++;
                    lblLossR.Text = rock.GlobalVariable.iLoss.ToString();
                }
                else
                {
                    lblOut.Text = ("You must choose rock, paper or scissors!");

                }

            }
            else if (rps == 2)
            {
                lblResult.Text = ("Paper");
                if (rpsU == 1)
                {
                    lblUResult.Text = ("Rock");
                    lblOut.Text = ("PUPP3R chose paper. You lost!");
                    rock.GlobalVariable.iLoss++;
                    lblLossR.Text = rock.GlobalVariable.iLoss.ToString();

                }
                else if (rpsU == 2)
                {
                    lblUResult.Text = ("Paper");
                    lblOut.Text = ("PUPP3R chose paper. It is a tie");
                    rock.GlobalVariable.iTie ++;
                    lblTieR.Text = rock.GlobalVariable.iTie.ToString();

                }
                else if (rpsU == 3)
                {
                    lblUResult.Text = ("Scissors");
                    lblOut.Text = ("PUPP3R chose paper. You won!");
                    rock.GlobalVariable.iWin++;
                    lblWinR.Text = rock.GlobalVariable.iWin.ToString();
                }
                else
                {
                    lblOut.Text = ("You must choose rock, paper or scissors!");
                }
            }
            else if (rps == 3)
            {
                lblResult.Text = ("Scissors");
                if (rpsU == 1)
                {
                    lblUResult.Text = ("Rock");
                    lblOut.Text = ("PUPP3R chose scissors. You won!");
                    rock.GlobalVariable.iWin++;
                    lblWinR.Text = rock.GlobalVariable.iWin.ToString();

                }
                else if (rpsU == 2)
                {
                    lblUResult.Text = ("Paper");
                    lblOut.Text = ("PUPP3R chose scissors. You lost!");
                    rock.GlobalVariable.iLoss++;
                    lblLossR.Text = rock.GlobalVariable.iLoss.ToString();

                }
                else if (rpsU == 3)
                {
                    lblUResult.Text = ("Scissors");
                    lblOut.Text = ("PUPP3R chose scissors. It is a tie");
                    rock.GlobalVariable.iTie ++;
                    lblTieR.Text = rock.GlobalVariable.iTie.ToString();

                }
                else
                {
                    lblOut.Text = ("You must choose rock, paper or scissors!");

                }

            }


        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            lblResult.Text = ("");
            lblUResult.Text = ("");
            lblOut.Text = ("");
            lblWinR.Text = ("0");
            lblLossR.Text = ("0");
            lblTieR.Text = ("0");
            rock.GlobalVariable.iTie = 0;
            rock.GlobalVariable.iLoss = 0;
            rock.GlobalVariable.iWin = 0;


        }

        private void lblLoss_Click(object sender, EventArgs e)
        {

        }
    }
}
