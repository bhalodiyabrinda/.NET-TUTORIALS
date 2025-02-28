namespace Tutorial7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selectedItems = listBox1.SelectedItems;
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(selectedItems[i]);
                listBox1.Items.Remove(selectedItems[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selectedItems = listBox2.SelectedItems;
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(selectedItems[i]);
                listBox2.Items.Remove(selectedItems[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
