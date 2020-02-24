using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PodstepnyBankier: Bankier
    {
        public PodstepnyBankier(string imie) : base(imie)
        {

        }
        public override float Licz(float jeden, float dwa)
        {
            int wynik = (int)(jeden + dwa);
            return (float)(wynik*0.8);
        }
    }
}
