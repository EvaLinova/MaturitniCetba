using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitníČetba
{
    //Třída studentů s atributy
    public class Student
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int RokNarozeni { get; set; }
        public int Rocnik { get; set; }

        //Listy pro jednotlivé studenty
        public BindingList<Dilo> PrectenaDila { get; private set; } = new BindingList<Dilo>();
        public BindingList<Dilo> BudeCist { get; private set; } = new BindingList<Dilo>();

        //Konstruktor
        public Student(string jmeno, string prijmeni, int rokNarozeni, int rocnik)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RokNarozeni = rokNarozeni;
            Rocnik = rocnik;
        }
    }
}
