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
            string sAd = "txt_ad", sSoyad = "txt_soyad", sTc = "txt_tc", sTip = "cmb_tip";
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
            Label lbltutar = new Label();
            lbltutar.Name = "lbl_tutar";
            lbltutar.Location = new Point(397, 227);
            lbltutar.Text = "Tutar";
            lbltutar.AutoSize = true;
            TextBox txttutar = new TextBox();
            txttutar.Name = "txt_tutar";
            txttutar.Location = new Point(468, 227);
            txttutar.ReadOnly = true;


            this.Controls.Add(lblad);
            this.Controls.Add(lblsoyad);
            this.Controls.Add(lbltc);
            this.Controls.Add(lbltip);
            this.Controls.Add(lbltutar);
            this.Controls.Add(txttutar);

            int xad = 125, xsoyad = 231, xtc = 340, xtip = 447, xlsayi = 50;
            int yad = 75, ysoyad = 75, ytc = 75, ytip = 75, ylsayi = 80;
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
    }
}
