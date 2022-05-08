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
    public partial class makinedurumsonuc : Form
    {
        string value;
        public static string cevap;
        
        public makinedurumsonuc()
        {
            InitializeComponent();
            timer1.Start();
           
        }
        
        

        private void panelguncelle1()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();
            
            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 1
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();          
            makineadi1LB.Text = sonuc.Makineler.makine_adi;
            makinetur1LB.Text = sonuc.Makineler.makine_turu;
            operator1LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker1LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum1LB.Text = sonuc.MakineDurum.durum_adi;
           
            
            

            if (sonuc.durum_id == 3)
            {
                ariza1LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure1LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure1LB.Text = Sure(zaman);
            }
            else
            {
                sure1LB.Text = "Süre durduruldu.";
            }
            
            switch (sonuc.durum_id)
            {
                case 1:
                    panel1.BackColor = Color.DeepSkyBlue;
                    panel1.ForeColor = Color.White;
                    break;
                case 2:
                    panel1.BackColor = Color.Green;
                    panel1.ForeColor = Color.White;
                    break;
                case 3:
                    panel1.BackColor = Color.Red;
                    panel1.ForeColor = Color.White;
                    break;
                default:
                    break;

            }



        }

        private void panelguncelle2()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 2
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();
            makineadi2LB.Text = sonuc.Makineler.makine_adi;
            makinetur2LB.Text = sonuc.Makineler.makine_turu;
            operator2LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker2LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum2LB.Text = sonuc.MakineDurum.durum_adi;


            if (sonuc.durum_id == 3)
            {
                ariza2LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure2LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure2LB.Text = Sure(zaman);
            }
            else
            {
                sure2LB.Text = "Süre durduruldu.";
            }
            switch (sonuc.durum_id)
            {
                case 1:
                    panel2.BackColor = Color.DeepSkyBlue;
                    panel2.ForeColor = Color.White;
                    break;
                case 2:
                    panel2.BackColor = Color.Green;
                    panel2.ForeColor = Color.White;
                    break;
                case 3:
                    panel2.BackColor = Color.Red;
                    panel2.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void panelguncelle3()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 3
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();
            makineadi3LB.Text = sonuc.Makineler.makine_adi;
            makinetur3LB.Text = sonuc.Makineler.makine_turu;
            operator3LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker3LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum3LB.Text = sonuc.MakineDurum.durum_adi;


            if (sonuc.durum_id == 3)
            {
                ariza3LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure3LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure3LB.Text = Sure(zaman);
            }
            else
            {
                sure3LB.Text = "Süre durduruldu.";
            }
            switch (sonuc.durum_id)
            {
                case 1:
                    panel3.BackColor = Color.DeepSkyBlue;
                    panel3.ForeColor = Color.White;
                    break;
                case 2:
                    panel3.BackColor = Color.Green;
                    panel3.ForeColor = Color.White;
                    break;
                case 3:
                    panel3.BackColor = Color.Red;
                    panel3.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void panelguncelle4()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 4
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();
            makineadi4LB.Text = sonuc.Makineler.makine_adi;
            makinetur4LB.Text = sonuc.Makineler.makine_turu;
            operator4LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker4LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum4LB.Text = sonuc.MakineDurum.durum_adi;


            if (sonuc.durum_id == 3)
            {
                ariza4LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure4LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure4LB.Text = Sure(zaman);
            }
            else
            {
                sure4LB.Text = "Süre durduruldu.";
            }
            switch (sonuc.durum_id)
            {
                case 1:
                    panel4.BackColor = Color.DeepSkyBlue;
                    panel4.ForeColor = Color.White;
                    break;
                case 2:
                    panel4.BackColor = Color.Green;
                    panel4.ForeColor = Color.White;
                    break;
                case 3:
                    panel4.BackColor = Color.Red;
                    panel4.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void panelguncelle5()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 5
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();
            makineadi5LB.Text = sonuc.Makineler.makine_adi;
            makinetur5LB.Text = sonuc.Makineler.makine_turu;
            operator5LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker5LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum5LB.Text = sonuc.MakineDurum.durum_adi;


            if (sonuc.durum_id == 3)
            {
                ariza5LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure5LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure5LB.Text = Sure(zaman);
            }
            else
            {
                sure5LB.Text = "Süre durduruldu.";
            }
            switch (sonuc.durum_id)
            {
                case 1:
                    panel6.BackColor = Color.DeepSkyBlue;
                    panel6.ForeColor = Color.White;
                    break;
                case 2:
                    panel6.BackColor = Color.Green;
                    panel6.ForeColor = Color.White;
                    break;
                case 3:
                    panel6.BackColor = Color.Red;
                    panel6.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void panelguncelle6()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 6
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();
            makineadi6LB.Text = sonuc.Makineler.makine_adi;
            makinetur6LB.Text = sonuc.Makineler.makine_turu;
            operator6LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker6LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum6LB.Text = sonuc.MakineDurum.durum_adi;


            if (sonuc.durum_id == 3)
            {
                ariza6LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure6LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure6LB.Text = Sure(zaman);
            }
            else
            {
                sure6LB.Text = "Süre durduruldu.";
            }
            switch (sonuc.durum_id)
            {
                case 1:
                    panel8.BackColor = Color.DeepSkyBlue;
                    panel8.ForeColor = Color.White;
                    break;
                case 2:
                    panel8.BackColor = Color.Green;
                    panel8.ForeColor = Color.White;
                    break;
                case 3:
                    panel8.BackColor = Color.Red;
                    panel8.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void panelguncelle7()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 7
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();
            makineadi7LB.Text = sonuc.Makineler.makine_adi;
            makinetur7LB.Text = sonuc.Makineler.makine_turu;
            operator7LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker7LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum7LB.Text = sonuc.MakineDurum.durum_adi;


            if (sonuc.durum_id == 3)
            {
                ariza7LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure7LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure7LB.Text = Sure(zaman);
            }
            else
            {
                sure7LB.Text = "Süre durduruldu.";
            }
            switch (sonuc.durum_id)
            {
                case 1:
                    panel7.BackColor = Color.DeepSkyBlue;
                    panel7.ForeColor = Color.White;
                    break;
                case 2:
                    panel7.BackColor = Color.Green;
                    panel7.ForeColor = Color.White;
                    break;
                case 3:
                    panel7.BackColor = Color.Red;
                    panel7.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void panelguncelle8()
        {
            FabrikaEntities fabrikaEntities = new FabrikaEntities();

            var kontrol = from faaliyet in fabrikaEntities.Faaliyet
                          where faaliyet.faaliyet_id == 8
                          select faaliyet;
            var sonuc = kontrol.FirstOrDefault();
            makineadi8LB.Text = sonuc.Makineler.makine_adi;
            makinetur8LB.Text = sonuc.Makineler.makine_turu;
            operator8LB.Text = sonuc.Operator.operator_adi + sonuc.Operator.operator_soyadi;
            tekniker8LB.Text = sonuc.Tekniker.tekniker_adi + sonuc.Tekniker.tekniker_soyadi;
            durum8LB.Text = sonuc.MakineDurum.durum_adi;


            if (sonuc.durum_id == 3)
            {
                ariza8LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_nedeni;
                sure8LB.Text = sonuc.ariza_id == null ? "" : sonuc.Ariza.ariza_tarih;
            }
            else if (sonuc.durum_id == 2)
            {

                var zaman = Convert.ToDateTime(sonuc.calisma_sure);
                sure8LB.Text = Sure(zaman);
            }
            else
            {
                sure8LB.Text = "Süre durduruldu.";
            }
            switch (sonuc.durum_id)
            {
                case 1:
                    panel5.BackColor = Color.DeepSkyBlue;
                    panel5.ForeColor = Color.White;
                    break;
                case 2:
                    panel5.BackColor = Color.Green;
                    panel5.ForeColor = Color.White;
                    break;
                case 3:
                    panel5.BackColor = Color.Red;
                    panel5.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }
        
        
        private string Sure(DateTime sure)
        {
            if(!(sure.Year<22))
            {
                var time = DateTime.Now.Subtract(sure);
                var saat = (byte)time.Hours;
                var dakika = (byte)time.TotalMinutes % 60;
                value = saat > 0 ? saat + " Saat " + dakika + " Dakika " : dakika + " Dakika ";
            }
            else
            {
                value = "Başlangıç zamanı gelmedi";
            }
            return value;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelguncelle1();
            panelguncelle2();
            panelguncelle3();
            panelguncelle4();
            panelguncelle5();  
            panelguncelle6();
            panelguncelle7();
            panelguncelle8();
        }

        public void geridon3_button_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();           
            Genel genel = new Genel();
            
            if (cevap =="operator")
            {                
                this.Hide();
                genel.Show();
                genel.calisanbutton.Visible = false;
                genel.stokbutton.Visible = false;
            }           
            else if (cevap=="tekniker")
            {
                this.Hide();
                genel.Show();
                genel.calisanbutton.Visible=false;
            }
            else
            {
                this.Hide();
                genel.Show();

            }

        }

        private void makinedurumsonuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
