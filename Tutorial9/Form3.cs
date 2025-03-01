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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\.NET\\Tutorial9\\Database1.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            q = "insert into [dbo].[Expense] (ExpID, StdID, Month, Year, TotalExpense)values(@ExpID, @StdID, @Month, @Year, @TotalExpense)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@ExpID", textBox1.Text);
            cmd.Parameters.AddWithValue("@StdID", textBox2.Text);
            cmd.Parameters.AddWithValue("@Month", textBox3.Text);
            cmd.Parameters.AddWithValue("@Year", textBox4.Text);
            cmd.Parameters.AddWithValue("@TotalExpense", textBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
