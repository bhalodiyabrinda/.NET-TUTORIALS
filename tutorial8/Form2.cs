using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial8
{
    public partial class Form2 : Form
    {
        private System.Windows.Forms.Timer timer; 
        private int currentLight = 0;
        public Form2()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer(); 
            timer.Interval = 1000;
            timer.Tick += new EventHandler(OnTimerTick);
            SetTrafficLight(0);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();

        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            currentLight = (currentLight + 1) % 3; 
            SetTrafficLight(currentLight);
        }

        private void SetTrafficLight(int light)
        {
            pictureBox1.BackColor = System.Drawing.Color.Gray;
            pictureBox2.BackColor = System.Drawing.Color.Gray;
            pictureBox3.BackColor = System.Drawing.Color.Gray;

            if (light == 0)
                pictureBox1.BackColor = System.Drawing.Color.Red;
            else if (light == 1)
                pictureBox2.BackColor = System.Drawing.Color.Green;
            else if (light == 2)
                pictureBox3.BackColor = System.Drawing.Color.Yellow;
        }
    }

}

