using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    public class Konum
    {
        public int KonumID { get; set; }
        public string KonumAd { get; set; }

        public Konum(string konumad )
        {
            this.KonumAd = konumad;
        }
    }
}
