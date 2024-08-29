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
namespace Motokurye
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand com;
        SqlDataAdapter adapter;
        public Form3()
        {
            InitializeComponent();
        }

       
        void kurye_yenile()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
            con.Open();
            adapter = new SqlDataAdapter("select * from Kuryeler", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'motorkuryeDataSet3.Kuryeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kuryelerTableAdapter1.Fill(this.motorkuryeDataSet3.Kuryeler);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into Kuryeler (Telefon_No,Kurye_Adi,Durum) values (@Telefon_No,@Kurye_Adi,@Durum)";
            com.Parameters.AddWithValue("@Kurye_Adi", textBox1.Text);
            com.Parameters.AddWithValue("@Telefon_No", textBox2.Text);
            com.Parameters.AddWithValue("@Durum", "Müsait");
            com.ExecuteNonQuery();
            con.Close();
            kurye_yenile();
            MessageBox.Show("Motokurye " + textBox1.Text + " eklendi");
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            int iddeger;

            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Kurye Bulunamadı");
            }
            else
            {
                iddeger = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "delete from Kuryeler where id=@id";
                com.Parameters.AddWithValue("@id", iddeger);
                com.ExecuteNonQuery();
                con.Close();
            }
            
            
            kurye_yenile();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 gecis3 = new Form2();
            gecis3.Show();
            this.Hide();
        }
    }
}
