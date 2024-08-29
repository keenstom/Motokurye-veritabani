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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Motokurye
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand com;
        SqlDataAdapter adapter;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 gecisilk = new Form1();
            gecisilk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into siparis (menu,adres) values (@p2,@p1)";
            com.Parameters.AddWithValue("@p1", adresbox.Text);
            com.Parameters.AddWithValue("@p2", "Pizza");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into siparis (menu,adres) values (@p2,@p1)";
            com.Parameters.AddWithValue("@p1", adresbox.Text);
            com.Parameters.AddWithValue("@p2", "Lahmacun");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into siparis (menu,adres) values (@p2,@p1)";
            com.Parameters.AddWithValue("@p1", adresbox.Text);
            com.Parameters.AddWithValue("@p2", "Hamburger");
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
