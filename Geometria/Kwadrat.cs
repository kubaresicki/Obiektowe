using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Kwadrat: Figura
    {

        public Kwadrat(int Dlugosc) : base(Dlugosc)
        {
            Console.WriteLine("Kwadrat");


        }

        public override void Rysuj()

        {
            for (int i = 0; i < Dlugosc; i++)
            {
                for(int j = 1; j < Dlugosc; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();


            }
        }
    
        public int Pole()
        {

            return Dlugosc * Dlugosc;
        }
    
    
    
    
    
    
    }





}
