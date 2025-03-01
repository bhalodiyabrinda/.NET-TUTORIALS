using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tutorial9

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\Tutorial9\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "insert into [dbo].[Table] (name, course, dob, address, mobail)values(@name, @course, @dob, @address, @mobail)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@course", textBox2.Text);
            cmd.Parameters.AddWithValue("@dob", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@mobail", textBox5.Text);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FORM [dbo].[Table]", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\Tutorial9\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "DELETE FROM [dbo].[Register] WHERE name = @name";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@course", textBox2.Text);
            cmd.Parameters.AddWithValue("@dob", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@mobail", textBox5.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FORM [dbo].[Table]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\Tutorial9\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "UPDATE [dbo].[Table] SET name = @name, course = @course, dob = @dob, address = @address, mobail = @mobail  WHERE name = @name";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@course", textBox2.Text);
            cmd.Parameters.AddWithValue("@dob", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@mobail", textBox5.Text);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FORM [dbo].[Table]", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
