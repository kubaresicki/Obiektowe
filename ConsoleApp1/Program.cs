using System;
using Geometria;

namespace ConsoleApp1
{

    class
        Program
    {


        static void Main(string[] args)
        {
            //ZADANIE 1_________+++++++++++
            //Figura[] f = new Figura[5];
            //f[0] = new Linia(7);
            //f[1] = new Kwadrat(13);
            //f[2] = new Figura(56);
            //f[3] = new Linia(26);
            //f[4] = new Kwadrat(36);

            //foreach(Figura x in f)
            //{
            //   x.Rysuj();
            // Console.WriteLine();
            //}
            //ZADANIE 2________++++++++++++++
            /* Console.WriteLine("kwadrat czy linia");
             string name = Console.ReadLine();
             Console.WriteLine("jaka wielkosc");
             int y = Int32.Parse(Console.ReadLine());
             if (name == "linia")
             {
                 Linia linia = new Linia(y);
                 linia.Rysuj();
             }
             if (name == "kwadrat")
             {
                 Kwadrat kwadrat = new Kwadrat(y);
                 kwadrat.Rysuj();

            }*/
            //ZADANIE 3__++++++++++++++++

            /*
                        Random r = new Random();
                        int liczba = r.Next();
                        Figura figura;
                        if (liczba % 2 == 0)
                            figura = new Linia(23);
                        else
                            figura = new Kwadrat(23);


                        //string typ = figura.getType().ToString();
                        string a = "sdfsg";
                        Console.WriteLine(a.GetType().ToString());
            */

            /*
            Rysownik.Test(new Kwadrat(4));
             

            Punkt p = new Punkt(53, 87);
            Punkt q = new Punkt(-3, -81);
            Console.WriteLine(p + q);
            Console.WriteLine(p - q);
            Console.ReadLine();
            
            PodstepnyBankier podstepny = new PodstepnyBankier("Jan");
            Console.WriteLine("podstępny"+podstepny.Licz(1, 2));

            UczciwyBankier bankier = new UczciwyBankier("Aleksander");
            Console.WriteLine("uczciwy"+bankier.Licz(1, 2));
              */

            int[] tab = new int[] { 1, 2, 3, 4, 5, 6 };
            Wektor w = new Wektor(tab);
            int[] tab1 = new int[] { 0, 1, 2, 3, 4, 5 };
            Wektor w1 = new Wektor(tab1);
            Console.WriteLine(w + w1);
            Console.WriteLine(w * w1);
        }
    }
}
