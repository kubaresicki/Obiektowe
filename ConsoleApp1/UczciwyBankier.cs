using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class UczciwyBankier : Bankier
    {
        public UczciwyBankier(string imie): base(imie)
        {
            
        }


            public override float Licz(float jeden, float dwa)
        {
            return jeden + dwa;
        }
    }
}
