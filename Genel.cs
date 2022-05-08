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
    public partial class Genel : Form
    {
        public Genel()
        {
            InitializeComponent();
        }

        

        private void makinedurumbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            makinedurumsonuc makinedurumsonuc = new makinedurumsonuc();
            makinedurumsonuc.Show();
            
        }

        private void stokbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            lastikstok lastikstok = new lastikstok();
            lastikstok.Show();
        }

        private void calisanbutton_Click(object sender, EventArgs e)
        {
            this.Hide();    
            calisanbilgisi calisanbilgisi = new calisanbilgisi();
            calisanbilgisi.Show();
        }

        private void durdur_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Genel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
