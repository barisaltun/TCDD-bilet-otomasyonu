using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    class GidisDonusRezervasyon: Rezervasyon
    {
        public Sefer DonusSeferi { get; set; }
        public GidisDonusRezervasyon(List<Yolcu> yolcular,Sefer gidisseferi,Sefer donusseferi) : base (yolcular,gidisseferi)
        {
           this.DonusSeferi = donusseferi;
           BireyselRezervasyonlarOlustur(donusseferi,yolcular);
           ToplamTutar = base.ToplamTutarHesapla();
        }
      
    }

}
