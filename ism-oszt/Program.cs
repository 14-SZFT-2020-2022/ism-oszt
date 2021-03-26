using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ism_oszt
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat animal = new Allat(2014, "Cucu");
            Console.WriteLine(animal.ToString());

            Kutya kutya = new Kutya("Vizsla")
            {
                SzuletesiEv = 2004,
                Nev = "Blöki"
            };
            Console.WriteLine(kutya.ToString());

            Console.ReadKey(true);
        }
    }

    class Allat
    {
        public int SzuletesiEv { get; set; }
        public string Nev { get; set; }

        public Allat(int szuletesiEv = 0, string nev = "")
        {
            this.SzuletesiEv = szuletesiEv;
            this.Nev = nev;
        }

        public override string ToString()
        {
            return $"Az állat neve: {this.Nev} és születési ideje: {this.SzuletesiEv}";
        }
    }

    class Kutya : Allat
    {
        public string Fajta { get; set; }
        public Kutya(string fajta) 
        {
            this.Fajta = fajta;
        }

        public override string ToString()
        {
            return base.ToString() + $" és fajtája: {this.Fajta}";
        }
    }
}
