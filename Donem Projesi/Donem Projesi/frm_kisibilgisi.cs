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
    public partial class frm_kisibilgisi : Form
    {
        public int yolcusayisi { get; set; }
        public frm_kisibilgisi(int gelensayi)
        {
            yolcusayisi = gelensayi;
            InitializeComponent();
        }

        private void FormTasarimOlustur()
        {
            string sAd = "txt_ad", sSoyad = "txt_soyad", sTc = "txt_tc", sTip = "cmb_tip", sOdeme = "chk_odeme";
            int xlad = 149, xlsoyad = 256, xltc = 351, xltip = 484;
            int ylad, ylsoyad, yltc, yltip;
            ylad = ylsoyad = yltc = yltip = 56;

            Label lblad = new Label();
            lblad.Name = "lbl_ad";
            lblad.Location = new Point(xlad, ylad);
            lblad.Text = "Ad";
            lblad.AutoSize = true;
            Label lblsoyad = new Label();
            lblsoyad.Name = "lbl_soyad";
            lblsoyad.Location = new Point(xlsoyad, ylsoyad);
            lblsoyad.Text = "Soyad";
            lblsoyad.AutoSize = true;
            Label lbltc = new Label();
            lbltc.Name = "lbl_tc";
            lbltc.Location = new Point(xltc, yltc);
            lbltc.Text = "Tc Kimlik NO";
            lbltc.AutoSize = true;
            Label lbltip = new Label();
            lbltip.Name = "lbl_tip";
            lbltip.Location = new Point(xltip, yltip);
            lbltip.Text = "Tip";
            lbltip.AutoSize = true;
            Label lblodeme = new Label();
            lblodeme.Name = "lbl_odeme";
            lblodeme.Location = new Point(xltip + 80, yltip);
            lblodeme.AutoSize = true;
            lblodeme.Text = " Odeme Yapacak \n          Yolcu";
            lblodeme.AutoSize = true;

           

            this.Controls.Add(lblodeme);
            this.Controls.Add(lblad);
            this.Controls.Add(lblsoyad);
            this.Controls.Add(lbltc);
            this.Controls.Add(lbltip);
           

            int xad = 125, xsoyad = 231, xtc = 340, xtip = 447, xlsayi = 50, xodeme = 580;
            int yad = 75, ysoyad = 75, ytc = 75, ytip = 75, ylsayi = 80, yodeme = 75;
            for (int i = 0; i < yolcusayisi + 1; i++)
            {
                Label lblsayi = new Label();
                lblsayi.Name = "lbl_sayi" + (i + 1);
                lblsayi.Location = new Point(xlsayi, ylsayi + i * 30);
                lblsayi.Text = (i + 1) + ".Müşterinin";
                lblsayi.AutoSize = true;

                TextBox txtad = new TextBox();
                txtad.Name = sAd + (i + 1);
                txtad.Location = new Point(xad, yad + (i * 30));
                TextBox txtsoyad = new TextBox();
                txtsoyad.Name = sSoyad + (i + 1);
                txtsoyad.Location = new Point(xsoyad, ysoyad + (i * 30));
                TextBox txttc = new TextBox();
                txttc.Name = sTc + (i + 1);
                txttc.Location = new Point(xtc, ytc + (i * 30));
                ComboBox cmbtip = new ComboBox();
                cmbtip.Name = sTip + (i + 1);
                cmbtip.Location = new Point(xtip, ytip + (i * 30));
                cmbtip.Items.Add("Ogrenci");
                cmbtip.Items.Add("Tam");
                CheckBox chkodeme = new CheckBox();
                chkodeme.Name = sOdeme + (i + 1);
                chkodeme.Location = new Point(xodeme, yodeme + (i * 30));
                this.Controls.Add(chkodeme);
                this.Controls.Add(lblsayi);
                this.Controls.Add(txtad);
                this.Controls.Add(txtsoyad);
                this.Controls.Add(txttc);
                this.Controls.Add(cmbtip);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FormTasarimOlustur();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            List<Yolcu> yolcular = new List<Yolcu>();
            Yolcu y;

            short odemeyapacakyolcuindisi = 0;
            string ad = "", soyad = "";
            long tc = 0;
            
            #region yolcutanimi
            for (int i = 0; i < yolcusayisi + 1; i++)
            {
                foreach (Control c in Controls)
                {
                    
                    if (c.Name == "txt_ad" + (i + 1))
                    {
                        ad = c.Text;
                    }
                    if (c.Name == "txt_soyad" + (i + 1))
                    {
                        soyad = c.Text;
                    }
                    if (c.Name == "txt_tc" + (i + 1))
                    {
                        tc = Convert.ToInt64(c.Text);
                    }
                    if (c.Name =="chk_odeme"+(i+1))
                    {
                        CheckBox cb = (CheckBox)c;
                        if (cb.Checked)
                        {
                            odemeyapacakyolcuindisi = (short)i;
                        }
                    }
                }
                foreach (Control cb in Controls)
                {
                    
                        if (cb.Name == "cmb_tip" + (i + 1))
                        {
                            if (cb.Text == "Ogrenci")
                            {
                                y = new OgrenciYolcu(ad, soyad, tc);
                                yolcular.Add(y);
                            }
                            else if (cb.Text == "Tam")
                            {
                                y = new TamYolcu(ad, soyad, tc);
                                yolcular.Add(y);
                            }

                        }



                }

                frm_seferbilgi.yolculistesi = yolcular;
                frm_seferbilgi.odemeyapacakyolcu = yolcular[odemeyapacakyolcuindisi];
            }
            #endregion

            this.Close();
        }
    }
}
