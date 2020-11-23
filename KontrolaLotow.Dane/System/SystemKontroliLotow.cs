using KontrolaLotow.Dane.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotow.Dane.System
{

    public class SystemKontroliLotow
    {
        public SystemKontroliLotow()
        {
            Console.WriteLine("System kontroli lotów został uruchomiony");
        }
        private Samolot sledzonySamolot;
        public void EkranObecnegoStanu()
        {
            Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
            Console.WriteLine("{0,15} {1,4} {2,10} {3,12} {4,12} {5,10}",
           "Identyfikator", "Typ", "Ładunek", "Wylecial z", "Leci do", "Dotrze o");
            Console.WriteLine("{0,15} {1,4} {2,10} {3,12} {4,12} {5,10}",
                sledzonySamolot.Identyfikator,
                sledzonySamolot.Rodzaj.ToString(),
                sledzonySamolot.Ladunek(),
                (sledzonySamolot.MiastoWylot?.Nazwa == null ? "brak" : sledzonySamolot.MiastoWylot.Nazwa),
                (sledzonySamolot.MiastoCel?.Nazwa == null ? "brak" : sledzonySamolot.MiastoCel.Nazwa),
                (Narzedzia.SzacujCzasDotarcia(sledzonySamolot).ToString() == null ? "brak" :
                Narzedzia.SzacujCzasDotarcia(sledzonySamolot).ToString()));;
        }
        public void SledzonySamolot(Samolot samolot)
        {
            sledzonySamolot = samolot;
            Console.WriteLine("Zarejestrowano " + sledzonySamolot.Identyfikator);
        }
    }
}
