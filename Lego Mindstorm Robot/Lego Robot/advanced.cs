using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lego_Robot
{
    public partial class advanced : Form
    {
        public advanced()
        {
            InitializeComponent();
        }

        private void advanced_Load(object sender, EventArgs e)
        {

        }

        private void bttnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Robot_Control Robot_Control = new Robot_Control();
            Robot_Control.ShowDialog();
        }
    }
}
