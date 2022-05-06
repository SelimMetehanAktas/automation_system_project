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

        private void girisyap() 
        { 
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from kullanici in fabrikaEntities.Kullanici
                          where kullanici.kullanıcı_adi == textBox1.Text && kullanici.sifre == textBox2.Text
                          select kullanici;
            if (kontrol.Any())
            {
                MessageBox.Show("Giriş Yapıldı");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
    }
}
