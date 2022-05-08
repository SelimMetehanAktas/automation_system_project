using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fabrika
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();           

        }

        private void giris_Click(object sender, EventArgs e)
        {
            girisyap();
        }

        public void girisyap() 
        { 
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from kullanici in fabrikaEntities.Kullanici
                          where kullanici.kullanıcı_adi == textBox3.Text && kullanici.sifre == textBox4.Text
                          select kullanici;

            var sonuc = kontrol.SingleOrDefault();
            makinedurumsonuc makinedurumsonuc = new makinedurumsonuc();
            makinedurumsonuc.cevap = textBox3.Text;
            lastikstok.cevap = textBox3.Text;
            Genel genel = new Genel();


            if (kontrol.Any())
            {
                MessageBox.Show("Giriş Yapıldı");
                this.Hide();
                if (textBox3.Text == "admin")
                {
                    
                    genel.Show();
                }
                else if(textBox3.Text == "tekniker")
                {
                    
                    genel.Show();
                    genel.calisanbutton.Visible = false; 
                }
                else
                {
                    
                    genel.Show();
                    genel.calisanbutton.Visible=false;
                    genel.stokbutton.Visible=false;
                }
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textBox4.Clear();
            } 
        
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                girisyap();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox4.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox4.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
