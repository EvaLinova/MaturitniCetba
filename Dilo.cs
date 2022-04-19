using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitníČetba
{
    //Abstraktní třída pro díla (zde jsou proměnné, které mají knihy a časopisy společné)
    public abstract class Dilo
    {
        public string Nazev { get; set; }
        public int RokVydani { get; set; }
        public string Vydavatelstvi { get; set; }

        //Konstruktor
        protected Dilo(string nazev, int rokVydani, string vydavatelstvi)
        {
            Nazev = nazev;
            RokVydani = rokVydani;
            Vydavatelstvi = vydavatelstvi;
        }
    }

    //Třída pro knihy, které dědí z Díla
    public class Kniha : Dilo
    {
        public string Jazyk { get; set; }
        public string LiterarniDruh { get; set; }

        //Konstruktor
        public Kniha(string nazev, int rokVydani, string vydavatelstvi, string jazyk, string literarniDruh) : base(nazev, rokVydani, vydavatelstvi)
        {
            Jazyk = jazyk;
            LiterarniDruh = literarniDruh;
        }
    }

    //Třída pro časopisy, dědící z Díla
    public class Casopis : Dilo
    {
        public string Zanr { get; set; }
        public int CisloVydani { get; set; }

        //Konstruktor
        public Casopis(string nazev, int rokVydani, string vydavatelstvi, string zanr, int cisloVydani) : base(nazev, rokVydani, vydavatelstvi)
        {
            Zanr = zanr;
            CisloVydani = cisloVydani;
        }
    }

}
