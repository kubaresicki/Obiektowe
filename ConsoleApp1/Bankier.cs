using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Bankier
    {
        protected string imie;
        public Bankier(string imie)
        {
            this.imie = imie;
        }

        

        public abstract float Licz(float jeden, float dwa);
    }

}



