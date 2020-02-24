using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Linia : Figura
    {
        public Linia(int Dlugosc) : base(Dlugosc)
        {
            Console.WriteLine("utowrzone linie");


        }

        public override void Rysuj()

        {
            for(int i = 1; i < Dlugosc; i++)
            {
                Console.Write("-");


            }
        }

    }
}
