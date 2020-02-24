using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Rysownik
    {

        public static void Test(Figura f)
        {
            f.Rysuj();
            string typ = f.GetType().ToString();
            if (typ == "Geometria.Kwadrat")
            {
                Kwadrat k = (Kwadrat)f;
                    Console.WriteLine(k.Pole());


            }



        }
    }
}
