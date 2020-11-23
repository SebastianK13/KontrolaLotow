using KontrolaLotow.Dane.Baza;
using KontrolaLotow.Dane.Model;
using KontrolaLotow.Dane.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace KontrolaLotow
{
    class Program
    {
        static void Main(string[] args)
        {
            //SystemKontroliLotow skl2 = new SystemKontroliLotow();
            //Repozytorium repo2 = new Repozytorium();
            //var miasto1 = repo2.WezMiasto("Kraków");
            //var miasto2 = repo2.WezMiasto("Seattle");
            //var samolot2 = repo2.WezSamolot(miasto1);
            //samolot2.MiastoCel = miasto2;
            //skl2.SledzonySamolot(samolot2);
            //skl2.EkranObecnegoStanu();

            //SystemKontroliLotow skl = new SystemKontroliLotow();
            //Repozytorium repo = new Repozytorium();
            //var samolot = repo.WezSamolot();
            //samolot.MiastoCel = repo.WezMiasto();
            //skl.SledzonySamolot(samolot);
            //skl.EkranObecnegoStanu();

            SystemKontroliLotow skl3 = new SystemKontroliLotow();
            Repozytorium repo3 = new Repozytorium();
            var miasto1 = repo3.WezMiasto("Gdańsk");
            var miasto2 = repo3.WezMiasto("Nowy York");
            var samolot3 = repo3.WezSamolot(200, 140);
            samolot3.MiastoWylot = miasto1;
            samolot3.MiastoCel = miasto2;
            skl3.SledzonySamolot(samolot3);
            skl3.EkranObecnegoStanu();
            var samolot4 = repo3.WezSamolot(miasto2 , 3000, 2500);
            samolot4.MiastoCel = miasto1;
            skl3.SledzonySamolot(samolot4);
            skl3.EkranObecnegoStanu();

            Console.ReadKey();
        }
    }
}
