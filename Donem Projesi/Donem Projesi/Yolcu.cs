using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    public abstract class Yolcu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TCKimlikNo { get; set; }
        public int Puan { get; set; }

        public Yolcu(string ad , string soyad , long tc)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.TCKimlikNo = tc;
        }
    }
}
