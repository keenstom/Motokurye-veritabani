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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
            
            // TODO: Bu kod satırı 'motorkuryeDataSet.Kullanici_Bilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanici_BilgiTableAdapter.Fill(this.motorkuryeDataSet.Kullanici_Bilgi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 gecis = new Form3();
            gecis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 gecis11 = new Form1();
            gecis11.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 gecis12 = new Form5();
            gecis12.Show(); this.Hide();
        }
    }
}
