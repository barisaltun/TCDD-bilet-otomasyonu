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


        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            foreach (Sefer c in seferler)

            {
                if (c.SeferZamani.Day == dateTimePicker1.Value.Day)
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
                if (secilenkalkis==s.KalkisKonumu.KonumAd)
                {
                    cmb_varis.Items.Add(s.VarisKonumu.KonumAd);
                }
            }
        }

        private void btn_odemeyap_Click(object sender, EventArgs e)
        {
                //Konumlar oluşturulacak
                //yolcular oluşmuş olacak..
                //rdo ya göre hangi tipte rezervasyon olduğu belirlenecek..
                //bilet oluştur ...
                //alttaki ödeme tipine göre ödeme yapacak yolcu fonksiyona yollanır ...
        }




    }
}
