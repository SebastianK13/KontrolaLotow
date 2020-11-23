using KontrolaLotow.Dane.Model;
using KontrolaLotow.Dane.Model.Samoloty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotow.Dane.Baza
{
        // 4. W klasie Repozytorium
        //a.Przeciąż metodę WezMiasto, która
        //i. Przyjmie jeden parametr tekstowy nazwaMiasta
        //ii. Ma zwrócić obiekt klasy Miasto z nazwą miasta pobraną w parametrze i
        //dowolnej lokalizacji (do wygenerowania pseudolosowych pozycji X i Y
        //skorzystaj z klasy Random)
        //b.Przeciąż metodę WezSamolot, która
        //i.Przyjmie jeden parametr miastowylotu typu Miasto
        //ii. Skonstruuje i zwróci nowy obiekt typu Samolot wykorzystując konstruktor z
        //trzema parametrami z wartościami identy
    public class Repozytorium
    {
        static Random rnd = new Random();
        public Miasto WezMiasto()
        {
            Miasto miasto = new Miasto();
            miasto.Nazwa = "Londyn";
            Polozenie polozenie = new Polozenie(1123, -2142);
            miasto.PolozenieM = polozenie;

            return miasto;
        }
        public Miasto WezMiasto(string nazwaMiasta)
        {
            Miasto miasto = new Miasto();
            miasto.Nazwa = nazwaMiasta;
            var x = Convert.ToSingle(rnd.Next(-5000, 5000));
            var y = Convert.ToSingle(rnd.Next(-5000, 5000));
            Polozenie polozenie = new Polozenie(x,y);
            miasto.PolozenieM = polozenie;

            return miasto;
        }
        public Samolot WezSamolot(Miasto miastoWylotu) => 
            new Samolot("Lot 23513", 900, miastoWylotu);

        public Samolot WezSamolot()
        {
            Polozenie polozenie = new Polozenie(131, 2255);
            Samolot samolot = new Samolot("Lot 94124", polozenie);

            return samolot;
        }

        public Samolot WezSamolot(int iloscMiejsc, int iloscPasazerow)
        {
            SamolotPasazerski samolotPasazerski = new SamolotPasazerski("Lot 33441", 870, iloscMiejsc);
            samolotPasazerski.IloscPasazerow = iloscPasazerow;

            return samolotPasazerski;
        }

        public Samolot WezSamolot(Miasto miastoWylotu, double maksymalnaWaga, double wagaLadunku)
        {
            SamolotTowarowy samolotTowarowy = new SamolotTowarowy("Lot 51314", 680, miastoWylotu, maksymalnaWaga);
            samolotTowarowy.WagaLadunku = wagaLadunku;

            return samolotTowarowy;
        }
    }
}
