using KontrolaLotow.Dane.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace KontrolaLotow.Dane.System
{
    public static class Narzedzia
    {
        static double PoliczOdleglosc(Polozenie start, Polozenie koniec) =>
            Math.Sqrt(Math.Pow((koniec.X - start.X), 2) + Math.Pow((koniec.Y - start.Y), 2));
        static public DateTime SzacujCzasDotarcia(Samolot samolot)
        {
            var odleglosc = PoliczOdleglosc(samolot.MiastoWylot.PolozenieM, samolot.MiastoCel.PolozenieM);
            TimeSpan czas = TimeSpan.FromHours(odleglosc / samolot.Predkosc);

            return DateTime.Now + czas;
        }
    }
}
