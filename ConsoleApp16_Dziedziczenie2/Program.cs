using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_Dziedziczenie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pojazd p1 = new Pojazd();
            //Console.WriteLine(p1.Nazwa + " - " + p1.Licz_kol);
            Motocykl m1 = new Motocykl("Yamaha",2);
            Console.WriteLine(m1.Nazwa + " - " + m1.Licz_kol + " - " + m1.Silnik);
            m1.Sound();
            Console.ReadKey();
        }
    }
}
