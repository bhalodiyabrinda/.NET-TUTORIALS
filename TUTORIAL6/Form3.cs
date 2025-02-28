using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
namespace TUTORIAL6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    // If input is not a number or control, stop the key event
            //    e.Handled = true;
            //    MessageBox.Show("Please enter numeric data only.");
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //if (!char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    // Block any input that is not an uppercase letter
            //    e.Handled = true;
            //    MessageBox.Show("Please enter uppercase letters only.");
            //}
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    // Block non-letter characters
            //    e.Handled = true;
            //    MessageBox.Show("Please enter alphabetic characters only.");
            //}
        }
    }
}
