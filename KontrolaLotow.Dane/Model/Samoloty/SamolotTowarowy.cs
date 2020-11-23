using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotow.Dane.Model.Samoloty
{
    public class SamolotTowarowy: Samolot
    {
        public SamolotTowarowy(string identyfikator, float predkosc, Miasto miastoWylotu,
            double maksymalnaWaga): base(identyfikator, predkosc, miastoWylotu)
        {
            MaksymalnaWaga = maksymalnaWaga;
        }

        public double WagaLadunku { get; set; }
        public double MaksymalnaWaga { get; protected set; }

        public override string Rodzaj => "T";

        public override string Ladunek()
        {
            return String.Format("{0}/{1}", WagaLadunku, MaksymalnaWaga);
        }
    }
}
