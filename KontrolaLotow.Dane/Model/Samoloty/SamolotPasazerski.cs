using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotow.Dane.Model.Samoloty
{
    public class SamolotPasazerski : Samolot
    {
        public SamolotPasazerski(string identyfikator, float predkosc, int iloscMiejsc) : base(identyfikator, predkosc)
        {
            IloscMiejsc = iloscMiejsc;
        }

        public int IloscMiejsc { get; protected set; }
        public int IloscPasazerow { get; set; }

        public override string Ladunek()
        {
            return String.Format("{0}/{1}", IloscPasazerow, IloscMiejsc);
        }

        public override string Rodzaj => "P";
    }
}
