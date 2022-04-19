using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitníČetba
{
    //Třída Databáze s údaji
    public static class Databaze
    {
        public static BindingList<Dilo> Dila { get; set; } = new BindingList<Dilo>();
        public static BindingList<Student> Studenti { get; set; } = new BindingList<Student>();

        //Metoda pro přidání údajů do Listů, které jsme si vytvořili above
        static Databaze()
        {
            Dila.Add(new Kniha("Romeo a Julie", 2015, "Arthur", "Angličtina", "Drama"));
            Dila.Add(new Kniha("Hamlet", 2012, "Arthur", "Angličtina", "Drama"));
            Dila.Add(new Kniha("Máj", 2007, "Russ", "Čeština", "Lyrika"));
            Dila.Add(new Kniha("Chrám Matky Boží v Paříži", 2018, "Arelia", "Francouzština", "Epika"));
            Dila.Add(new Kniha("Utrpení mladého Werthera", 2000, "Arthur", "Němčina", "Epika"));
            Dila.Add(new Kniha("Oliver Twist", 2018, "Russ", "Angličtina", "Epika"));
            Dila.Add(new Kniha("David Copperfield", 2000, "Arthur", "Angličtina", "Epika"));
            Dila.Add(new Kniha("Paní Bovaryová", 2008, "Arelia", "Francouzština", "Epika"));
            Dila.Add(new Kniha("Povídky malostránské", 2004, "Russ", "Čeština", "Epika"));
            Dila.Add(new Kniha("Hřbitovní kvítí", 2009, "Arthur", "Čeština", "Lyrika"));
            Dila.Add(new Kniha("Krakonošova zahrada", 2015, "Arelia", "Čeština", "Epika"));
            Dila.Add(new Kniha("Krakatit", 2008, "Arelia", "Čeština", "Epika"));
            Dila.Add(new Kniha("Norské dřevo", 2010, "Arthur", "Japonština", "Epika"));
            Dila.Add(new Kniha("Let it snow", 2018, "Arelia", "Angličtina", "Epika"));
            Dila.Add(new Kniha("Papírová města", 2018, "Arelia", "Angličtina", "Epika"));

            Dila.Add(new Casopis("ABC", 2018, "CNC", "Vědecko-technický", 7));
            Dila.Add(new Casopis("21. století", 2020, "Hobby_cz", "Historický", 5));
            Dila.Add(new Casopis("Blesk", 2019, "CNC","Zábavný", 4));
            Dila.Add(new Casopis("CREW", 2021, "CREW", "Zábavný", 9));
            Dila.Add(new Casopis("Vesmír", 2017, "CNC", "Vědecko-technický", 4));
            Dila.Add(new Casopis("Sluníčko", 2015, "Děti", "Dětské", 8));

            Studenti.Add(new Student("Anika", "Alpská", 2003, 8));
            Studenti.Add(new Student("Ben", "Budiž", 2001, 6));
            Studenti.Add(new Student("Cecilia", "Copatá", 2002, 6));
            Studenti.Add(new Student("Daniel", "Dumal", 2001, 4));
            Studenti.Add(new Student("Evelyn", "Elise", 2003, 8));
            Studenti.Add(new Student("František", "Fík", 2001, 4));
            Studenti.Add(new Student("Gustaf", "Grál", 2002, 6));
            Studenti.Add(new Student("Hana", "Hrozivá", 2003, 8));

        }
    }
}
