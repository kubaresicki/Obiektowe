using System;
using System.Text;
using System.Collections.Generic;

namespace Geometria
{
    public abstract class Figura
    {
        protected int Dlugosc;

        public Figura(int Dlugosc)
        {

            this.Dlugosc = Dlugosc;
        }
        public abstract void Rysuj();

        public override  string ToString()
        {
            return "dlugosc: " + Dlugosc;


        }


    }
}
