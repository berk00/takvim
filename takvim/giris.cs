using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace takvim
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\takvim.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
             baglan.Open();
            OleDbCommand komut = new OleDbCommand("insert into Tablo1 (ad,soyad,sayi) values (@p1,@p2,@p3)",baglan);
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", label7.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Olma İşlemi başarılı");
            button1.Enabled = false;


            

        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut=new OleDbCommand("select * from Tablo1 where ad=@p1 and soyad=@p2",baglan);
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1.hedef = textBox3.Text;
                Form1.ad = textBox1.Text;
                Form1.soyad = textBox2.Text;


                Form1 sayfa = new Form1();
                sayfa.Show();
                this.Hide();


            }
            else
            {

                MessageBox.Show("Adınız Veya Soyadınız yanlış");



            }
            baglan.Close();
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1 ", baglan);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);




            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label5.Visible = true;
                button1.Visible = false;
                label4.Visible = false;


            }

            else
            {
                label5.Visible = false;
                button1.Visible = true;
                label4.Visible = true;
            }
            baglan.Close();

        }
    }
}
