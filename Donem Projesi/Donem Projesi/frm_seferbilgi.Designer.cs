namespace TCDD
{
    partial class frm_seferbilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdo_tekyon = new System.Windows.Forms.RadioButton();
            this.rdo_gidisdonus = new System.Windows.Forms.RadioButton();
            this.btn_yolcubilgiekle = new System.Windows.Forms.Button();
            this.cmb_kalkis = new System.Windows.Forms.ComboBox();
            this.cmb_varis = new System.Windows.Forms.ComboBox();
            this.lbl_kalkis = new System.Windows.Forms.Label();
            this.lbl_varis = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_yolcusayisi = new System.Windows.Forms.Label();
            this.cmb_yolcusayisi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_odemetipi = new System.Windows.Forms.Label();
            this.rdo_kredikarti = new System.Windows.Forms.RadioButton();
            this.rdo_nakit = new System.Windows.Forms.RadioButton();
            this.rdo_puan = new System.Windows.Forms.RadioButton();
            this.btn_odemeyap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_tekyon
            // 
            this.rdo_tekyon.AutoSize = true;
            this.rdo_tekyon.Location = new System.Drawing.Point(28, 19);
            this.rdo_tekyon.Name = "rdo_tekyon";
            this.rdo_tekyon.Size = new System.Drawing.Size(66, 17);
            this.rdo_tekyon.TabIndex = 2;
            this.rdo_tekyon.TabStop = true;
            this.rdo_tekyon.Text = "Tek Yön";
            this.rdo_tekyon.UseVisualStyleBackColor = true;
            // 
            // rdo_gidisdonus
            // 
            this.rdo_gidisdonus.AutoSize = true;
            this.rdo_gidisdonus.Location = new System.Drawing.Point(118, 19);
            this.rdo_gidisdonus.Name = "rdo_gidisdonus";
            this.rdo_gidisdonus.Size = new System.Drawing.Size(82, 17);
            this.rdo_gidisdonus.TabIndex = 3;
            this.rdo_gidisdonus.TabStop = true;
            this.rdo_gidisdonus.Text = "Gidiş-Dönüş";
            this.rdo_gidisdonus.UseVisualStyleBackColor = true;
            // 
            // btn_yolcubilgiekle
            // 
            this.btn_yolcubilgiekle.Location = new System.Drawing.Point(139, 223);
            this.btn_yolcubilgiekle.Name = "btn_yolcubilgiekle";
            this.btn_yolcubilgiekle.Size = new System.Drawing.Size(159, 23);
            this.btn_yolcubilgiekle.TabIndex = 4;
            this.btn_yolcubilgiekle.Text = "Yolcu Bilgilerini Ekle";
            this.btn_yolcubilgiekle.UseVisualStyleBackColor = true;
            this.btn_yolcubilgiekle.Click += new System.EventHandler(this.btn_yolcubilgiekle_Click);
            // 
            // cmb_kalkis
            // 
            this.cmb_kalkis.FormattingEnabled = true;
            this.cmb_kalkis.Location = new System.Drawing.Point(122, 127);
            this.cmb_kalkis.Name = "cmb_kalkis";
            this.cmb_kalkis.Size = new System.Drawing.Size(121, 21);
            this.cmb_kalkis.TabIndex = 6;
            this.cmb_kalkis.SelectedIndexChanged += new System.EventHandler(this.cmb_kalkis_SelectedIndexChanged);
            // 
            // cmb_varis
            // 
            this.cmb_varis.FormattingEnabled = true;
            this.cmb_varis.Location = new System.Drawing.Point(122, 154);
            this.cmb_varis.Name = "cmb_varis";
            this.cmb_varis.Size = new System.Drawing.Size(121, 21);
            this.cmb_varis.TabIndex = 6;
            // 
            // lbl_kalkis
            // 
            this.lbl_kalkis.AutoSize = true;
            this.lbl_kalkis.Location = new System.Drawing.Point(49, 132);
            this.lbl_kalkis.Name = "lbl_kalkis";
            this.lbl_kalkis.Size = new System.Drawing.Size(35, 13);
            this.lbl_kalkis.TabIndex = 8;
            this.lbl_kalkis.Text = "Kalkış";
            // 
            // lbl_varis
            // 
            this.lbl_varis.AutoSize = true;
            this.lbl_varis.Location = new System.Drawing.Point(49, 157);
            this.lbl_varis.Name = "lbl_varis";
            this.lbl_varis.Size = new System.Drawing.Size(30, 13);
            this.lbl_varis.TabIndex = 8;
            this.lbl_varis.Text = "Varış";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(48, 80);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(31, 13);
            this.lbl_tarih.TabIndex = 8;
            this.lbl_tarih.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_yolcusayisi
            // 
            this.lbl_yolcusayisi.AutoSize = true;
            this.lbl_yolcusayisi.Location = new System.Drawing.Point(49, 185);
            this.lbl_yolcusayisi.Name = "lbl_yolcusayisi";
            this.lbl_yolcusayisi.Size = new System.Drawing.Size(64, 13);
            this.lbl_yolcusayisi.TabIndex = 25;
            this.lbl_yolcusayisi.Text = "Yolcu Sayısı";
            // 
            // cmb_yolcusayisi
            // 
            this.cmb_yolcusayisi.FormattingEnabled = true;
            this.cmb_yolcusayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_yolcusayisi.Location = new System.Drawing.Point(122, 182);
            this.cmb_yolcusayisi.Name = "cmb_yolcusayisi";
            this.cmb_yolcusayisi.Size = new System.Drawing.Size(121, 21);
            this.cmb_yolcusayisi.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_gidisdonus);
            this.groupBox1.Controls.Add(this.rdo_tekyon);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 44);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lbl_odemetipi
            // 
            this.lbl_odemetipi.AutoSize = true;
            this.lbl_odemetipi.Location = new System.Drawing.Point(52, 255);
            this.lbl_odemetipi.Name = "lbl_odemetipi";
            this.lbl_odemetipi.Size = new System.Drawing.Size(61, 13);
            this.lbl_odemetipi.TabIndex = 29;
            this.lbl_odemetipi.Text = "Ödeme Tipi";
            // 
            // rdo_kredikarti
            // 
            this.rdo_kredikarti.AutoSize = true;
            this.rdo_kredikarti.Location = new System.Drawing.Point(122, 279);
            this.rdo_kredikarti.Name = "rdo_kredikarti";
            this.rdo_kredikarti.Size = new System.Drawing.Size(73, 17);
            this.rdo_kredikarti.TabIndex = 28;
            this.rdo_kredikarti.TabStop = true;
            this.rdo_kredikarti.Text = "Kredi Kartı";
            this.rdo_kredikarti.UseVisualStyleBackColor = true;
            // 
            // rdo_nakit
            // 
            this.rdo_nakit.AutoSize = true;
            this.rdo_nakit.Location = new System.Drawing.Point(55, 278);
            this.rdo_nakit.Name = "rdo_nakit";
            this.rdo_nakit.Size = new System.Drawing.Size(50, 17);
            this.rdo_nakit.TabIndex = 27;
            this.rdo_nakit.TabStop = true;
            this.rdo_nakit.Text = "Nakit";
            this.rdo_nakit.UseVisualStyleBackColor = true;
            // 
            // rdo_puan
            // 
            this.rdo_puan.AutoSize = true;
            this.rdo_puan.Location = new System.Drawing.Point(223, 278);
            this.rdo_puan.Name = "rdo_puan";
            this.rdo_puan.Size = new System.Drawing.Size(50, 17);
            this.rdo_puan.TabIndex = 28;
            this.rdo_puan.TabStop = true;
            this.rdo_puan.Text = "Puan";
            this.rdo_puan.UseVisualStyleBackColor = true;
            // 
            // btn_odemeyap
            // 
            this.btn_odemeyap.Location = new System.Drawing.Point(223, 307);
            this.btn_odemeyap.Name = "btn_odemeyap";
            this.btn_odemeyap.Size = new System.Drawing.Size(75, 23);
            this.btn_odemeyap.TabIndex = 30;
            this.btn_odemeyap.Text = "Ödeme Yap";
            this.btn_odemeyap.UseVisualStyleBackColor = true;
            this.btn_odemeyap.Click += new System.EventHandler(this.btn_odemeyap_Click);
            // 
            // frm_seferbilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 349);
            this.Controls.Add(this.btn_odemeyap);
            this.Controls.Add(this.lbl_odemetipi);
            this.Controls.Add(this.rdo_puan);
            this.Controls.Add(this.rdo_kredikarti);
            this.Controls.Add(this.rdo_nakit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_yolcusayisi);
            this.Controls.Add(this.cmb_yolcusayisi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lbl_varis);
            this.Controls.Add(this.lbl_kalkis);
            this.Controls.Add(this.cmb_varis);
            this.Controls.Add(this.cmb_kalkis);
            this.Controls.Add(this.btn_yolcubilgiekle);
            this.Name = "frm_seferbilgi";
            this.Text = "Sefer Bilgileri ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_tekyon;
        private System.Windows.Forms.RadioButton rdo_gidisdonus;
        private System.Windows.Forms.Button btn_yolcubilgiekle;
        private System.Windows.Forms.ComboBox cmb_kalkis;
        private System.Windows.Forms.ComboBox cmb_varis;
        private System.Windows.Forms.Label lbl_kalkis;
        private System.Windows.Forms.Label lbl_varis;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_yolcusayisi;
        private System.Windows.Forms.ComboBox cmb_yolcusayisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_odemetipi;
        private System.Windows.Forms.RadioButton rdo_kredikarti;
        private System.Windows.Forms.RadioButton rdo_nakit;
        private System.Windows.Forms.RadioButton rdo_puan;
        private System.Windows.Forms.Button btn_odemeyap;

    }
}

