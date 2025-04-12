using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopek
{
    public class Kopek
    {
        public string cinsi;
        public int yasi;
        public string renk;
        public double kilosu;

        public Kopek(int yasi)
        {
            Console.WriteLine("yasi");
            this.yasi = yasi;
        }

        public Kopek(double kilosu)
        {
            Console.WriteLine("kilosu");
            this.kilosu = kilosu;
        }
        public Kopek(double kilosu, int yasi)
        {
            Console.WriteLine("Cift Parametreli Yapici");
            this.yasi = yasi;
            this.yasi = yasi;
        }
        private int insanYasiniHesapla()
        {
            return (yasi) * 6;
        }
        public void ozellikYazdir()
        {
            Console.WriteLine("Köpegin cinsi " + cinsi);
            Console.WriteLine("Köpegin rengi " + renk);
            Console.WriteLine("Köpegin yasi " + yasi);
            Console.WriteLine("Köpegin kilosu " + kilosu);
            Console.WriteLine("Köpegin insan yasi " + insanYasiniHesapla());

        }
    }
}
