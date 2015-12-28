using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCDD
{

    public partial class frm_seferbilgi : Form
    {
        public frm_seferbilgi()
        {
            InitializeComponent();
        }

        List<Sefer> seferler = SeferleriAl.SeferAl();
        public static List<Yolcu> yolculistesi;
        public Rezervasyon rezervasyon;
        public static Yolcu odemeyapacakyolcu;



        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            foreach (Sefer c in seferler)
            {
                if (c.SeferZamani.Day == dateTimePicker_gidis.Value.Day)
                {
                    if (!cmb_kalkis.Items.Contains(c.KalkisKonumu.KonumAd))
                    {
                        cmb_kalkis.Items.Add(c.KalkisKonumu.KonumAd);


                    }
                }
            }
        }
        private void btn_yolcubilgiekle_Click(object sender, EventArgs e)
        {
            short yolcusayisi = (short)cmb_yolcusayisi.SelectedIndex;
            frm_kisibilgisi f2 = new frm_kisibilgisi(yolcusayisi);
            f2.Show();
        }

        private void cmb_kalkis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenkalkis;

            secilenkalkis = (string)cmb_kalkis.SelectedItem;

            foreach (Sefer s in seferler)
            {
                if (secilenkalkis == s.KalkisKonumu.KonumAd)
                {
                    cmb_varis.Items.Add(s.VarisKonumu.KonumAd);
                }
            }
        }

        private void btn_odemeyap_Click(object sender, EventArgs e)
        {

            eOdemeTipi odemetipi = eOdemeTipi.NakitOdeme;
            if (rdo_nakit.Checked)
            {
                odemetipi = eOdemeTipi.NakitOdeme;
            }
            else if (rdo_kredikarti.Checked)
            {
                odemetipi = eOdemeTipi.KrediKarti;
            }
            else if (rdo_puan.Checked)
            {
                odemetipi = eOdemeTipi.PuanlaOdeme;
            }
            Bilet bilet = new Bilet(odemetipi, rezervasyon, odemeyapacakyolcu);

            if (bilet.OdemeYap(odemetipi, rezervasyon))
            {
                string biletbilgi = "";
                foreach (Yolcu y in rezervasyon.Yolcular)
                {
                    biletbilgi += "Yolcu Adı : " + y.Ad + " " + y.Soyad + "\n Kalkış yeri: " + rezervasyon.GidisSeferi.KalkisKonumu.KonumAd + "\nVarış yeri: " + rezervasyon.GidisSeferi.VarisKonumu.KonumAd + "\n";

                }
                biletbilgi += "Toplam tutar: " + rezervasyon.ToplamTutar + "\n";
                biletbilgi += "Ödeme tipi:" + odemetipi;
                MessageBox.Show(biletbilgi);
            }
            else
            {
                MessageBox.Show("Ödeme yapılamadi");
            }




            //alttaki ödeme tipine göre ödeme yapacak yolcu fonksiyona yollanır ...
        }

        private void rdo_tekyon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_tekyon.Checked)
            {
                dateTimePicker_donus.Visible = false;
                lbl_donus.Visible = false;
            }
            else
            {
                dateTimePicker_donus.Visible = true;
                lbl_donus.Visible = true;
            }
        }

        private void btnRezervasyonOlustur_Click(object sender, EventArgs e)
        {
            if (rdo_tekyon.Checked)
            {
                foreach (Sefer s in seferler)
                {
                    if (cmb_kalkis.Text == s.KalkisKonumu.KonumAd && cmb_varis.Text == s.VarisKonumu.KonumAd)
                    {
                        rezervasyon = new TekYonRezervasyon(yolculistesi, s);
                    }
                }
            }

            else if (rdo_gidisdonus.Checked)
            {
                Sefer sgidis = null, sdonus = null;
                foreach (Sefer s in seferler)
                {
                    if (cmb_kalkis.Text == s.KalkisKonumu.KonumAd && cmb_varis.Text == s.VarisKonumu.KonumAd)
                    {
                        sgidis = s;

                    }
                    else if (cmb_varis.Text == s.KalkisKonumu.KonumAd && cmb_kalkis.Text == s.VarisKonumu.KonumAd)
                    {
                        sdonus = s;
                    }
                }
                rezervasyon = new GidisDonusRezervasyon(yolculistesi, sgidis, sdonus);
            }
            lblTutar.Text = "Rezervasyon tutarı: " + rezervasyon.ToplamTutar;

        }




    }
}
