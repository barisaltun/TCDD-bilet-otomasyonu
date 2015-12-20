using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    public class BireyselRezervasyon
    {
        private Yolcu yolcu{ get; set; }
        private Sefer sefer { get; set; }
        public decimal BireyselRezervasyonTutari { get; private set; }

        public BireyselRezervasyon(Yolcu y , Sefer s)
        {
            this.yolcu = y;
            this.sefer = s;
            BireyselRezervasyonTutari = BireyselRezervasyonTutariHesapla();
        }
        private decimal BireyselRezervasyonTutariHesapla() 
        {
            decimal fiyat = 0;
            if (yolcu is OgrenciYolcu)
            {
                fiyat = sefer.SeferUcreti * (0.85M);
            }
            else if (yolcu is TamYolcu)
            {
                fiyat = sefer.SeferUcreti;
           }
            return fiyat;
        }
    }
}
