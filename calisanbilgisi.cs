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
    public partial class calisanbilgisi : Form
    {
        public calisanbilgisi()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=DESKTOP-HEFJQI8;Initial Catalog=Fabrika;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);

        DataTable guncelle1()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT operator_adi,operator_soyadi FROM Operator", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }

        DataTable guncelle2()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT tekniker_adi,tekniker_soyadi FROM Tekniker", baglan);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglan.Close();
            return tablo;
        }


        private void calisanbilgisi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = guncelle1();
            dataGridView2.DataSource = guncelle2();
        }

        private void operatorekle_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "INSERT INTO Operator (operator_adi,operator_soyadi) VALUES (@operator_adi,@operator_soyadi)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@operator_adi", operatoradi_textBox.Text);
                    komut.Parameters.AddWithValue("@operator_soyadi", operatorsoyadi_textBox.Text);

                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Operator Ekleme İşlemi Başarılı");
                    dataGridView1.DataSource = guncelle1();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var" + hata.Message);
            }
                
        }

        private void operatorsil_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("delete from Operator where operator_adi = '" + dataGridView1.SelectedRows[i].Cells["operator_adi"].Value + "'", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            MessageBox.Show("Kayıtlar Silindi");
            dataGridView1.DataSource = guncelle1();
        }

        private void teknikerekle_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "INSERT INTO Tekniker (tekniker_adi,tekniker_soyadi) VALUES (@tekniker_adi,@tekniker_soyadi)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@tekniker_adi", teknikerad_textBox.Text);
                    komut.Parameters.AddWithValue("@tekniker_soyadi", teknikersoyad_textBox.Text);

                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("Tekniker Ekleme İşlemi Başarılı");
                    dataGridView2.DataSource = guncelle2();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Var" + hata.Message);
            }
        }

        private void teknikersil_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("delete from Tekniker where tekniker_adi = '" + dataGridView2.SelectedRows[i].Cells["tekniker_adi"].Value + "'", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            MessageBox.Show("Kayıtlar Silindi");
            dataGridView2.DataSource = guncelle2();
        }

        private void geridon1_button_Click(object sender, EventArgs e)
        {
            Hide();
            Genel genel = new Genel();
            genel.Show();
        }

        private void calisanbilgisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
