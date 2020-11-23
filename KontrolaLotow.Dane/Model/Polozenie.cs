using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotow.Dane.Model
{
    public class Polozenie
    {
        public Polozenie(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public float X { get; private set; }
        public float Y { get; private set; }

        public void Zmien(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
