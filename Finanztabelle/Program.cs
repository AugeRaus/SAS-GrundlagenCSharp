using System;

namespace Finanztabelle
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bitte geben sie ihr Kapital ein");
           double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben sie ihr Zinssatz ein");
           double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben sie ihre Anlagendauer ein");
           short j = Convert.ToInt16(Console.ReadLine());

           
            double KZinsen = 0;
            double Bilanz = 0;
            double kn = k;
            double Zinsen = 0;



            Console.WriteLine($"{"Jahr",4} {"Guthaben",10} {"Zinsen",8} {"K.Zinsen",10} {"Bilanz",8}");

            for(int i = 1; i<=44;i++)
            {
                Console.Write("_");


            }
            Console.WriteLine();


            for (int i = 1;i<=j;i++)
            {
                Zinsen = kn * (z / 100);
                KZinsen = KZinsen + Zinsen;
                Bilanz = k + KZinsen;
                


                
                Console.WriteLine($"{i,4} {kn,10:F2} {Zinsen,8:F2} {KZinsen,10:F2} {Bilanz,8:F2}");

                kn = Bilanz;
            }
        }
    }
}
