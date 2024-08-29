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
    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand com;
        SqlDataAdapter adapter;
        string selectedValue;
        public Form5()
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
        void siparis_yenile()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
            con.Open();
            adapter = new SqlDataAdapter("select * from siparis", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'motorkuryeDataSet4.siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter.Fill(this.motorkuryeDataSet4.siparis);
            // TODO: Bu kod satırı 'motorkuryeDataSet4.Kuryeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kuryelerTableAdapter1.Fill(this.motorkuryeDataSet4.Kuryeler);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 gecisler2 = new Form2();
            gecisler2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
            if (dataGridView2.RowCount == 1)
            {
                MessageBox.Show("Sipariş Bulunamadı");
            }
            else
            {

                selectedValue = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                int selectedid = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "select id from siparis where id='"+selectedid+"'";            
                string adresdeger;
                adresdeger = com.ExecuteScalar()?.ToString();
                com.ExecuteNonQuery();
                con.Close();
                textBox1.Text = selectedValue;
            }
            

            kurye_yenile();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            if (dataGridView2.RowCount == 1)
            {
                MessageBox.Show("Sipariş Bulunamadı");
            }
            else
            {
                int siparisdeger;
                siparisdeger = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "delete from Siparis where id=@id";
                com.Parameters.AddWithValue("@id", siparisdeger);
                com.ExecuteNonQuery();
                con.Close();
            }
            siparis_yenile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kuryesec;
            
            if (textBox1.Text == null)
            {
                MessageBox.Show("Adres Seçin");
            }
            else
            {
                kuryesec = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "update Kuryeler set durum = @Dolu, Hedef_Adres=@adres2 where id =@id";
                com.Parameters.AddWithValue("@id", kuryesec);
                com.Parameters.AddWithValue("@Dolu", "Dolu");
                com.Parameters.AddWithValue("@adres2",textBox1.Text);

                com.ExecuteNonQuery();
                con.Close();
            }
            siparis_yenile();
            kurye_yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int kuryesec2;

            if (textBox1.Text == null)
            {
                MessageBox.Show("Adres Seçin");
            }
            else
            {
                kuryesec2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                con = new SqlConnection("Data Source=.;Initial Catalog=Motorkurye;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "update Kuryeler set durum = @Dolu, Hedef_Adres=@adres2 where id =@id";
                com.Parameters.AddWithValue("@id", kuryesec2);
                com.Parameters.AddWithValue("@Dolu", "Müsait");
                com.Parameters.AddWithValue("@adres2", "Kurye Boşta");

                com.ExecuteNonQuery();
                con.Close();
            }
            siparis_yenile();
            kurye_yenile();
        }
    }
}
