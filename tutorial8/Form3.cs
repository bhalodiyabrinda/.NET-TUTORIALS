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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Copy();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Paste();

        }
    }
}
