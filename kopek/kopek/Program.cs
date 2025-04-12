using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kopek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek a1 = new Kopek(3);
            a1.yasi = 3;
            a1.cinsi = "golden";
            a1.kilosu = 15;
            a1.renk = "turuncu";
            a1.ozellikYazdir();
        }
    }
}
