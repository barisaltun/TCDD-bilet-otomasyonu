using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    public abstract class Rezervasyon
    {
        public int YolcuSayisi { get; set; }
        public List<Yolcu> Yolcular{ get; set; }
        public List<BireyselRezervasyon> bRezervasyonlar{ get; private set; }
        public decimal ToplamTutar { get; protected set; }
        public Sefer GidisSeferi { get; set; }

        public Rezervasyon(List<Yolcu> yolcular, Sefer sefer)
        {
            this.GidisSeferi = sefer;
            this.Yolcular = yolcular;
            this.bRezervasyonlar = new List<BireyselRezervasyon>();
            BireyselRezervasyonlarOlustur(GidisSeferi,Yolcular);
            ToplamTutar = ToplamTutarHesapla();                        
        }
        public virtual decimal ToplamTutarHesapla()
        {

            decimal toplam = 0;
            foreach (BireyselRezervasyon rez in bRezervasyonlar)
            {
                toplam += rez.BireyselRezervasyonTutari;
            }
            return toplam;
        }
        protected virtual void BireyselRezervasyonlarOlustur(Sefer sefer, List<Yolcu> yolcular)
        {

            foreach (Yolcu y in Yolcular)
            {
                BireyselRezervasyon br = new BireyselRezervasyon(y,sefer);
                bRezervasyonlar.Add(br);    
            }
        }


        //public string BiletleriListele()
        //{
        //    string mesaj = "";

        //    foreach (Yolcu y in Yolcular)
        //    {

        //    }


        //}
    }
}
