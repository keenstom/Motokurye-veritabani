using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Motokurye
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand com;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            if (radioButton1.Checked)
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "select*from Kullanici_Bilgi where kullanici_adi='" + textBox1.Text + "'and sifre='"
                    + textBox2.Text + "'";
                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Giriş Başarılı");
                    Form4 gecismüsteri = new Form4();
                    gecismüsteri.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }
                con.Close();
                
            }
            else if (radioButton2.Checked) 
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "select*from isletmeler where isletme_ad='" + textBox1.Text + "'and isletme_sifre='"
                    + textBox2.Text + "'";
                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Giriş Başarılı");
                    Form2 gecis = new Form2();
                    gecis.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }
                con.Close();
                
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                    con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                    com = new SqlCommand();
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into Kullanici_Bilgi (kullanici_adi,sifre) values (@p1,@p2)";
                    com.Parameters.AddWithValue("@p1", textBox1.Text);
                    com.Parameters.AddWithValue("@p2", textBox2.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt Başarılı");
                

            }
            else if (radioButton2.Checked)
            {
            
               
                    con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                    com = new SqlCommand();
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into isletmeler (isletme_ad,isletme_sifre) values (@p1,@p2)";
                    com.Parameters.AddWithValue("@p1", textBox1.Text);
                    com.Parameters.AddWithValue("@p2", textBox2.Text);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt Başarılı");
                
            }
        }
    }
}
