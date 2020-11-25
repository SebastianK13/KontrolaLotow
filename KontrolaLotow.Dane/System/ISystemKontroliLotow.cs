using KontrolaLotow.Dane.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotow.Dane.System
{
    public interface ISystemKontroliLotow
    {
        void ZarejestrujSamolot(Samolot samolot);
        void PokazWidok(Widok widok);
    }
}
