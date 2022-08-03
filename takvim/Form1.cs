using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.IO;
namespace takvim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string hedef,ad,soyad;
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\takvim.mdb");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            pictureBox1.BackColor = Color.Lime;
            baglan.Open();

            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", label13.Text);


            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr[14].ToString();
                


            }

            baglan.Close();
            panel1.Visible = true;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "0";
            pictureBox1.BackColor = Color.White;
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo1 set sayi=@p1,sayi2=@p2,sayi3=@p3,sayi4=@p4,sayi5=@p5,sayi6=@p6,sayi7=@p7,sayi8=@p8,sayi9=@p9,sayi10=@p10,sayi11=@p11 where ad=@p111", baglan);
            komut.Parameters.AddWithValue("@p1", label1.Text);
            komut.Parameters.AddWithValue("@p2", label3.Text);
            komut.Parameters.AddWithValue("@p3", label4.Text);
            komut.Parameters.AddWithValue("@p4", label5.Text);
            komut.Parameters.AddWithValue("@p5", label6.Text);
            komut.Parameters.AddWithValue("@p6", label7.Text);
            komut.Parameters.AddWithValue("@p7", label8.Text);
            komut.Parameters.AddWithValue("@p8", label9.Text);
            komut.Parameters.AddWithValue("@p9", label10.Text);
            komut.Parameters.AddWithValue("@p10", label11.Text);
            komut.Parameters.AddWithValue("@p11", label12.Text);
            komut.Parameters.AddWithValue("@p111", label13.Text);
           
            
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            







            baglan.Open();

            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1",label13.Text);


            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[1].ToString();
                label3.Text = dr[2].ToString();
                label4.Text = dr[3].ToString();
                label5.Text = dr[4].ToString();
                label6.Text = dr[5].ToString();
                label7.Text = dr[6].ToString();
                label8.Text = dr[7].ToString();
                label9.Text = dr[8].ToString();
                label10.Text = dr[9].ToString();
                label11.Text = dr[10].ToString();


            }

            baglan.Close();
            label2.Text = hedef.ToString();
            label13.Text = ad.ToString();
            label14.Text = soyad.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();

            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", label13.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                label1.Text = dr[1].ToString();
                label3.Text = dr[2].ToString();
                label4.Text = dr[3].ToString();
                label5.Text = dr[4].ToString();
                label6.Text = dr[5].ToString();
                label7.Text = dr[6].ToString();
                label8.Text = dr[7].ToString();
                label9.Text = dr[8].ToString();
                label10.Text = dr[9].ToString();
                label11.Text = dr[10].ToString();
               
               
            }
            
            
            baglan.Close();
            
                        
            
            if (label1.Text=="1")
            {
               pictureBox1.BackColor = Color.Red; 
            }
            if (label1.Text == "0")
            {
                pictureBox1.BackColor = Color.White;
            }
            if (label3.Text == "1")
            {
                pictureBox2.BackColor = Color.Red;
            }
            if (label3.Text == "0")
            {
                pictureBox2.BackColor = Color.White;
            }
            if (label4.Text == "1")
            {
                pictureBox3.BackColor = Color.Red;
            }
            if (label4.Text == "0")
            {
                pictureBox3.BackColor = Color.White;
            }
            if (label5.Text == "1")
            {
                pictureBox4.BackColor = Color.Red;
            }
            if (label5.Text == "0")
            {
                pictureBox4.BackColor = Color.White;
            }
            if (label6.Text == "1")
            {
                pictureBox5.BackColor = Color.Red;
            }
            if (label6.Text == "0")
            {
                pictureBox5.BackColor = Color.White;
            }
            if (label7.Text == "1")
            {
                pictureBox6.BackColor = Color.Red;
            }
            if (label7.Text == "0")
            {
                pictureBox6.BackColor = Color.White;

            }
            if (label8.Text == "1")
            {
                pictureBox7.BackColor = Color.Red;
            }
            if (label8.Text == "0")
            {
                pictureBox7.BackColor = Color.White;

            }
            if (label9.Text == "1")
            {
                pictureBox8.BackColor = Color.Red;
            }
            if (label9.Text == "0")
            {
                pictureBox8.BackColor = Color.White;

            }
            if (label11.Text == "1")
            {
                pictureBox10.BackColor = Color.Red;
            }
            if (label11.Text == "0")
            {
                pictureBox10.BackColor = Color.White;

            }
            if (label12.Text == "1")
            {
                pictureBox11.BackColor = Color.Red;
            }
            if (label12.Text == "0")
            {
                pictureBox11.BackColor = Color.White;

            }
            if (label15.Text == "1")
            {
                pictureBox12.BackColor = Color.Red;
            }
            if (label15.Text == "0")
            {
                pictureBox12.BackColor = Color.White;

            }
            if (label16.Text == "1")
            {
                pictureBox13.BackColor = Color.Red;
            }
            if (label16.Text == "0")
            {
                pictureBox13.BackColor = Color.White;

            }
            if (label17.Text == "1")
            {
                pictureBox14.BackColor = Color.Red;
            }
            if (label17.Text == "0")
            {
                pictureBox14.BackColor = Color.White;

            }
            if (label18.Text == "1")
            {
                pictureBox15.BackColor = Color.Red;
            }
            if (label18.Text == "0")
            {
                pictureBox15.BackColor = Color.White;

            }
            if (label19.Text == "1")
            {
                pictureBox16.BackColor = Color.Red;
            }
            if (label19.Text == "0")
            {
                pictureBox16.BackColor = Color.White;

            }

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3.Text = "1";
            pictureBox2.BackColor = Color.Lime;

            baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", label13.Text);


            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr[15].ToString();



            }

            baglan.Close();



            panel2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label4.Text = "1";
            pictureBox3.BackColor = Color.Lime;
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", label13.Text);


            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox3.Text = dr[16].ToString();



            }

            baglan.Close();



            panel3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label5.Text = "1";
            pictureBox4.BackColor = Color.Lime;
 baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", label13.Text);

           
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox4.Text = dr[17].ToString();



            }

            baglan.Close();



            panel4.Visible = true;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            label7.Text = "1";
            pictureBox6.BackColor = Color.Lime;


            baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", label13.Text);


            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox6.Text = dr[19].ToString();



            }

            baglan.Close();
            panel6.Visible = true;
            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label6.Text = "1";
            pictureBox5.BackColor = Color.Lime;
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from Tablo1 where ad=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", label13.Text);

            
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox5.Text = dr[18].ToString();



            }

            baglan.Close();



            panel5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label8.Text = "1";
            pictureBox7.BackColor = Color.Lime;
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            label5.Text = "0";
            pictureBox4.BackColor = Color.White;
            panel4.Visible = false;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            label3.Text = "0";
            pictureBox2.BackColor = Color.White;
            panel2.Visible = false;
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            label4.Text = "0";
            pictureBox3.BackColor = Color.White;
            panel3.Visible = false;
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            label6.Text = "0";
            pictureBox5.BackColor = Color.White;
            panel5.Visible = false;
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            label7.Text = "0";
            pictureBox6.BackColor = Color.White;
            panel6.Visible = false;
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            label8.Text = "0";
            pictureBox7.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris sayfa = new giris();
            sayfa.Show();
            this.Hide();
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {




            //baglan.Open();
            //OleDbCommand ekle = new OleDbCommand("insert into Tablo1 (sayi,sayi2,sayi3,sayi4,sayi5,sayi6,sayi7,sayi8,sayi9,sayi10,sayi11) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglan);
            //ekle.Parameters.AddWithValue("@p1", label1.Text);
            //ekle.Parameters.AddWithValue("@p2", label3.Text);
            //ekle.Parameters.AddWithValue("@p3", label4.Text);
            //ekle.Parameters.AddWithValue("@p4", label5.Text);
            //ekle.Parameters.AddWithValue("@p5", label6.Text);
            //ekle.Parameters.AddWithValue("@p6", label7.Text);
            //ekle.Parameters.AddWithValue("@p7", label8.Text);
            //ekle.Parameters.AddWithValue("@p8", label9.Text);
            //ekle.Parameters.AddWithValue("@p9", label10.Text);
            //ekle.Parameters.AddWithValue("@p10", label11.Text);
            //ekle.Parameters.AddWithValue("@p11", label12.Text);
            //ekle.ExecuteNonQuery();
            //baglan.Close();
            dateTimePicker1.Visible = true;
        }

        private void pictureBox9_DoubleClick(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label9.Text = "1";
            pictureBox8.BackColor = Color.Lime;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label11.Text = "1";
            pictureBox10.BackColor = Color.Lime;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label12.Text = "1";
            pictureBox11.BackColor = Color.Lime;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label15.Text = "1";
            pictureBox12.BackColor = Color.Lime;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

            label16.Text = "1";
            pictureBox13.BackColor = Color.Lime;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label17.Text = "1";
            pictureBox14.BackColor = Color.Lime;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label18.Text = "1";
            pictureBox15.BackColor = Color.Lime;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label19.Text = "1";
            pictureBox16.BackColor = Color.Lime;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label20.Text = "1";
            pictureBox17.BackColor = Color.Lime;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            label21.Text = "1";
            pictureBox18.BackColor = Color.Lime;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            label22.Text = "1";
            pictureBox22.BackColor = Color.Lime;
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            label9.Text = "0";
            pictureBox8.BackColor = Color.White;
        }

        private void pictureBox10_DoubleClick(object sender, EventArgs e)
        {
            label11.Text = "0";
            pictureBox8.BackColor = Color.White;
        }

        private void pictureBox11_DoubleClick(object sender, EventArgs e)
        {
            label12.Text = "0";
            pictureBox11.BackColor = Color.White;
        }

        private void pictureBox12_DoubleClick(object sender, EventArgs e)
        {
            label15.Text = "0";
            pictureBox12.BackColor = Color.White;
        }

        private void pictureBox13_DoubleClick(object sender, EventArgs e)
        {
            label16.Text = "0";
            pictureBox13.BackColor = Color.White;
        }

        private void pictureBox14_DoubleClick(object sender, EventArgs e)
        {
            label17.Text = "0";
            pictureBox14.BackColor = Color.White;
        }

        private void pictureBox15_DoubleClick(object sender, EventArgs e)
        {
            label18.Text = "0";
            pictureBox15.BackColor = Color.White;
        }

        private void pictureBox16_DoubleClick(object sender, EventArgs e)
        {
            label19.Text = "0";
            pictureBox16.BackColor = Color.White;
        }

        private void pictureBox17_DoubleClick(object sender, EventArgs e)
        {
            label20.Text = "0";
            pictureBox17.BackColor = Color.White;
        }

        private void pictureBox18_DoubleClick(object sender, EventArgs e)
        {
            label21.Text = "0";
            pictureBox18.BackColor = Color.White;
        }

        private void pictureBox22_DoubleClick(object sender, EventArgs e)
        {
            label22.Text = "0";
            pictureBox22.BackColor = Color.White;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo1 set not1=@p1 where ad=@p111", baglan);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p111",label13.Text);
            


            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo1 set not2=@p1 where ad=@p111", baglan);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p111", label13.Text);



            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo1 set not3=@p1 where ad=@p111", baglan);
            komut.Parameters.AddWithValue("@p1", textBox3.Text);
            komut.Parameters.AddWithValue("@p111", label13.Text);



            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo1 set not4=@p1 where ad=@p111", baglan);
            komut.Parameters.AddWithValue("@p1", textBox4.Text);
            komut.Parameters.AddWithValue("@p111", label13.Text);



            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo1 set not5=@p1 where ad=@p111", baglan);
            komut.Parameters.AddWithValue("@p1", textBox5.Text);
            komut.Parameters.AddWithValue("@p111", label13.Text);



            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("update Tablo1 set not6=@p1 where ad=@p111", baglan);
            komut.Parameters.AddWithValue("@p1", textBox6.Text);
            komut.Parameters.AddWithValue("@p111", label13.Text);



            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_PrintPage;
            PrintDialog dlgSettings = new PrintDialog();
            dlgSettings.Document = doc;
            if (dlgSettings.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        
        
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.panel1.Width, this.panel1.Height);
            this.panel1.DrawToBitmap(bmp, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }


        

        }
    }

