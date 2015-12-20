using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    public class Sefer
    {
        public Konum KalkisKonumu { get; set; }
        public Konum VarisKonumu { get; set; }
        public DateTime SeferZamani = new DateTime();
        public decimal SeferUcreti { get; set; }
        public bool SeferAktifMi { get; set; }
        public int KalanKoltukSayisi { get; set; }

        public Sefer( Konum kalkis,Konum varis)
        {
            KalkisKonumu = kalkis;
            VarisKonumu = varis;
        }
    }
}
