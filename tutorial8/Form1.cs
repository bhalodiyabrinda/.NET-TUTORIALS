namespace tutorial8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Nodes: {treeView1.GetNodeCount(true)}");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                treeView1.Nodes.Add(textBox2.Text);
                textBox2.Clear(); // Clear the textbox after adding
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                textBox1.Clear(); // Clear the textbox after adding
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }
    }
}
