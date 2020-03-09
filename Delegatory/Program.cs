using System;

namespace Delegatory
{
    class Program
    {
        public delegate int Delegator(int a, int b);
        public delegate string Delegator1(string s);
        public static int Mnozenie(int a, int b)
        {
            return a * b;
        }
        public static int Test(int a, int b, Delegator del)
        {
            return del(a, b);
        }
        public static int Maks(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b; }
        static void Main(string[] args)
        {

            //Utwórz funkcję lambda (int) => (int) która zwraca ile razy wykona się następująca pętla: jeżeli a jest parzyste - podziel przez 2, jeżeli nieparzyste - pomnóż przez 3 i dodaj 1.
            Func<int, int> lambda = (a) =>
            {
                int counter = 0;
                while (a != 1)
                {
                    if (a % 2 == 0)
                        a = a / 2;
                    else
                        a = 3 * a + 1;
                    counter++;
                }
                return counter;
            };
            //Utwórz funkcję lambda (string, bool) => (string), która ucina pierwszą literę albo ostatnią w zależności od wartości parametru logicznego.
            Func<string, bool> lamb = (string a) =>
            {
                bool prawda;
                if (prawda)
                    a.Substring(0);
                else
                    a.Substring(a.Length);
                return a;
            };



            Delegator1[] del1 = new Delegator1[5];
           
            del1[0] = (s) => { return s + s + s; };
            del1[1] = (s) =>
            {
                string wynik = "";
                wynik = s.Substring(0, 3);
                return wynik;
            };

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(del1[i]("miś"));
            }
            Delegator del;
            del = Mnozenie;
            /*
            Console.Write(del(5, 3));
            Console.WriteLine(Test(3, 5, del));
            */    
    }
    }
}
