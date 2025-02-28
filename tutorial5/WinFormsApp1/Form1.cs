namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the input values
                double number1 = double.Parse(textBox1.Text);
                double number2 = double.Parse(textBox2.Text);
                double result = 0;

                // Perform the selected operation
                if (radioButton1.Checked)
                {
                    result = number1 + number2;
                }
                else if (radioButton2.Checked)
                {
                    result = number1 - number2;
                }
                else if (radioButton3.Checked)
                {
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (radioButton4.Checked)
                {
                    result = number1 * number2;
                }

                textBox3.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
