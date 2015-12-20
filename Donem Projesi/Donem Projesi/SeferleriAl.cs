using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCDD
{
    public static class SeferleriAl
    {
        static Konum Istanbul = new Konum("İstanbul");
        static Konum Izmır= new Konum("İzmir");
        static Konum Ankara= new Konum("Ankara");
        static Konum Eskisehir = new Konum("Eskişehir");
        private static List<Sefer> SeferListesi = new List<Sefer>();
        public static List<Sefer> SeferAl(){

            Sefer IstanbulAnkara = new Sefer(Istanbul,Ankara)
            {
                KalanKoltukSayisi = 200,
                SeferUcreti = 50,
                SeferZamani = DateTime.Today,
                SeferAktifMi=true

            };
            Sefer AnkaraIstanbul = new Sefer(Ankara,Istanbul)
            {
                KalanKoltukSayisi = 200,
                SeferUcreti = 50,
                SeferZamani = DateTime.Today,
                SeferAktifMi = true

            };
            Sefer IzmırAnkara = new Sefer(Izmır,Ankara)
            {
                KalanKoltukSayisi = 200,
                SeferUcreti = 35,
                SeferZamani = DateTime.Today,
            SeferAktifMi=true
            };
            Sefer AnkaraIzmır= new Sefer(Ankara, Izmır)
            {
                KalanKoltukSayisi = 200,
                SeferUcreti = 35,
                SeferZamani = DateTime.Today,
                SeferAktifMi = true
            };
            Sefer EskisehirAnkara = new Sefer(Eskisehir,Ankara)
            {
                KalanKoltukSayisi = 200,
                SeferUcreti = 15,
                SeferZamani = DateTime.Today,
                SeferAktifMi=true
            };
            Sefer AnkaraEskisehir= new Sefer(Ankara,Eskisehir)
            {
                KalanKoltukSayisi = 200,
                SeferUcreti = 15,
                SeferZamani = DateTime.Today,
                SeferAktifMi = true
            };
                       
            SeferListesi.Add(IzmırAnkara);
            SeferListesi.Add(IstanbulAnkara);
            SeferListesi.Add(EskisehirAnkara);
            SeferListesi.Add(AnkaraEskisehir);
            SeferListesi.Add(AnkaraIstanbul);
            SeferListesi.Add(AnkaraIzmır);
            return SeferListesi;
    }
    }
}
