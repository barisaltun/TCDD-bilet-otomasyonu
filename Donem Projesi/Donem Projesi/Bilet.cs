using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    public class Bilet
    {
        public Rezervasyon rezervasyon { get; set; }

        public Yolcu OdemeYapanYolcu { get; private set; }


        public Bilet(eOdemeTipi oTip, Rezervasyon r, Yolcu odemeyapacakyolcu)
        {
            this.OdemeYapanYolcu = odemeyapacakyolcu;
            
        }
        public bool OdemeYap(eOdemeTipi oTip, Rezervasyon r)
        {
            bool OdemeAlindiMi = false;
            switch (oTip)
            {
                case eOdemeTipi.NakitOdeme:
                    {
                        OdemeYapanYolcu.Puan += (int)r.ToplamTutar / 1000;
                        OdemeAlindiMi = true;
                    }
                    break;
                case eOdemeTipi.KrediKarti:
                    {
                        OdemeYapanYolcu.Puan += (int)r.ToplamTutar / 1000;
                        OdemeAlindiMi = true;
                    }
                    break;
                case eOdemeTipi.PuanlaOdeme:
                    {
                        if (OdemeYapanYolcu.Puan > r.ToplamTutar)
                        {
                            OdemeYapanYolcu.Puan -= (int)r.ToplamTutar;
                            OdemeAlindiMi = true;
                        }
                        else
                            OdemeAlindiMi = false;  // puan yeterli ise puanla ödeme değilse ödemenin puanla yapılamayacağı....
                    }

                    break;
            }
            return OdemeAlindiMi;

        }
    }
}
