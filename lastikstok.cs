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

namespace fabrika
{
    public partial class lastikstok : Form
    {
        public static string cevap;
        public lastikstok()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=DESKTOP-HEFJQI8;Initial Catalog=Fabrika;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);

        DataTable guncelle()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM Lastik", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }
        
        public void kayit_getir()
        {           
            string getir = "Select * From Lastik";
            
            SqlCommand komut = new SqlCommand(getir,baglan);

            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(baglan.State==ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "INSERT INTO Lastik (lastik_id,lastik_turu,lastik_ebat,yuk_endeksi,arac_turu) VALUES (@lastik_id,@lastik_turu,@lastik_ebat,@yuk_endeksi,@arac_turu)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@lastik_id", textBox1.Text);
                    komut.Parameters.AddWithValue("@lastik_turu", textBox5.Text);
                    komut.Parameters.AddWithValue("@lastik_ebat", textBox4.Text);
                    komut.Parameters.AddWithValue("@yuk_endeksi", textBox3.Text);
                    komut.Parameters.AddWithValue("@arac_turu", textBox2.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var : " + hata.Message);
            }
        }

        private void listele_button_Click(object sender, EventArgs e)
        {
            kayit_getir();
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("delete from Lastik where lastik_id = '"+dataGridView1.SelectedRows[i].Cells["lastik_id"].Value.ToString()+"'",baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            MessageBox.Show("Kayıtlar Silindi");
            dataGridView1.DataSource = guncelle();
        }

        private void geridon3_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Genel genel = new Genel();

            if (cevap == "operator")
            {
                this.Hide();
                genel.Show();
                genel.calisanbutton.Visible = false;
                genel.stokbutton.Visible = false;
            }
            else if (cevap == "tekniker")
            {
                this.Hide();
                genel.Show();
                genel.calisanbutton.Visible = false;
            }
            else
            {
                this.Hide();
                genel.Show();

            }
        }

        private void lastikstok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
