using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Punkt
    {
        public int WspX, WspY;


        public static Punkt operator+(Punkt a, Punkt b)
        {
            Punkt wynik = new Punkt(a.WspX + b.WspX, a.WspY + b.WspY);
            return wynik;
        }
        public static Punkt operator-(Punkt a, Punkt b)
        {
            Punkt wynik = new Punkt(a.WspX - b.WspX, a.WspY - b.WspY);
            return wynik;
        }
        /*
        public static Punkt operator *(Punkt a, Punkt b)
        {
            Punkt wynik = new Punkt((a.WspX + b.WspX)* (a.WspY + b.WspY));
            return wynik;
        }*/
        public Punkt(int WspX, int WspY)
        {
            this.WspX = WspX;
            this.WspY = WspY;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1})", WspX, WspY);
        }
    }
}
