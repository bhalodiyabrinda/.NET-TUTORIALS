using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\Tutorial9\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "insert into [dbo].[Student] (StdID, Name, Univarsity, City, State)values(@StdID, @Name, @Univarsity, @City, @State)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@StdID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Univarsity", textBox3.Text);
            cmd.Parameters.AddWithValue("@City", textBox4.Text);
            cmd.Parameters.AddWithValue("@State", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
