using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_Dziedziczenie2
{
    class Motocykl: Pojazd
    {
        public string Silnik { get; set; }
        public Motocykl(string Nazwa, int Licz_kol, string Silnik="BRAK"):base(Nazwa,Licz_kol)
        {
            this.Silnik = Silnik;
        }
    }
}
