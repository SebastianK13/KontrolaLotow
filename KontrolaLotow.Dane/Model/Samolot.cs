using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotow.Dane.Model
{

    public abstract class Samolot
    {
        public Samolot(string identyfikator, float predkosc)
        {
            Identyfikator = identyfikator;
            Predkosc = predkosc;
        }
        public Samolot(string identyfikator, Polozenie polozenie)
        {
            Identyfikator = identyfikator;
            Pozycja = polozenie;
        }
        public Samolot(string identyfikator, float predkosc, Miasto miastoWylotu)
        {
            Identyfikator = identyfikator;
            Predkosc = predkosc;
            MiastoWylot = miastoWylotu;
            Pozycja = miastoWylotu.PolozenieM;
        }
        public string Identyfikator { get; private set; }
        public float Predkosc { get; set; }
        public Polozenie Pozycja { get; private set; }
        public Miasto MiastoWylot { get; set; }
        public Miasto MiastoCel { get; set; }
        //public virtual string Rodzaj 
        //{
        //    get
        //    {
        //        return "S";
        //    } 
        //}
        //public virtual string Ladunek() => "brak";

        public abstract string Rodzaj
        {
            get;
        }
        public abstract string Ladunek();

    }
}
