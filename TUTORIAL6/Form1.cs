using System.Xml.Linq;

namespace TUTORIAL6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            // Determine the appropriate salutation based on gender
            string salutation = radioButton1.Checked ? "Mr." : "Miss";

            // Collect the selected sources of information
            string sources = "";
            if (checkBox1.Checked) sources += "Newspaper, ";
            if (checkBox3.Checked) sources += "Website, ";
            if (checkBox2.Checked) sources += "Friends, ";
            if (checkBox4.Checked) sources += checkBox4.Text + ", ";

            // Remove the last comma and space if any sources were selected
            if (sources.Length > 0)
            {
                sources = sources.Substring(0, sources.Length - 2);
            }

            // Construct and display the final message
            Output.Text = $"Hello {salutation} {name}. You know about us from {sources}.";

        }

        private void Output_Click(object sender, EventArgs e)
        {

        }
    }
}
