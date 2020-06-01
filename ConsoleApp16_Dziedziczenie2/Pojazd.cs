using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_Dziedziczenie2
{
    class Pojazd
    {
        public string Nazwa { get; set; }
        public int Licz_kol { get; set; }

        public Pojazd(string Nazwa="BRAK", int Licz_kol=0)
        {
            this.Nazwa = Nazwa;
            this.Licz_kol = Licz_kol;
        }

        public void Sound()
        {
            Console.WriteLine("trtrtrtr");
        }
    }
}
