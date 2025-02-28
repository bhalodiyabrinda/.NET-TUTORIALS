using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUTORIAL6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Education");
            listBox1.Items.Add("Food for all");
            listBox1.Items.Add("Freedom of Speech");
            listBox1.Items.Add("Good Books");
            listBox1.Items.Add("Good Movies");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Total Items: " + listBox1.Items.Count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sortedItems = listBox1.Items.Cast<string>().OrderBy(item => item).ToArray();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(sortedItems);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button1.Text = "Total Items: 0";
            button1.Text = "Your Selection: ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                label2.Text = "Your Selection: ";
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label2.Text = "Your Selection: " + listBox1.SelectedItem.ToString();
            }
        }
    }
}
