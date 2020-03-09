using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Wektor
    {

        public int[] tab;

        public  Wektor(int[] tab)
        {
            this.tab = tab;
        }

        public static Wektor operator +(Wektor a, Wektor b)
        {
            if (a.tab.Length == b.tab.Length)
            {
                int[] tab = new int[a.tab.Length];
                int[] tab1 = new int[b.tab.Length];
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = a.tab[i] + b.tab[i];
                };
                return new Wektor(tab);

            }
            else
                return null;
        }
        public static int operator *(Wektor a, Wektor b)
        {
            if (a.tab.Length == b.tab.Length)
            {
                int[] tab = new int[a.tab.Length];
                int[] tab1 = new int[b.tab.Length];
                int wynik = 0;
                for (int i = 0; i < a.tab.Length; i++)
                {
                    tab[i] = a.tab[i] * b.tab[i];
                    wynik += tab[i];
                };
                return wynik;

            }
            else
                return 0;
        }
        public override string ToString()
        {
            string w = "[";
            for (int i=0; i<tab.Length; i++)
            {
                if((i + 1) != tab.Length)
                w += tab[i] + ",";
                if ((i + 1) == tab.Length)
                {
                    w += "}";
                }
            }
            return w;
          
        }


    }
}
