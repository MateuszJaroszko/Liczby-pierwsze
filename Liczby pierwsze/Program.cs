using System;

namespace Liczby_pierwsze
{
    class Program
    {
        public static void Main(string[] args)
        {
            int ile = Convert.ToInt32(Console.ReadLine());
            int p;
            int i = 0;
            int counter = 0; 
            while(counter <ile) 
            {
                int wynik = czyPierwsza(i);
                i += 1;
                if (wynik != 0)
                {
                    counter += 1;
                    Console.WriteLine(wynik);
                }
            }
            
             



        }
        public static int czyPierwsza(int num)
        {

            bool pierwsza = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    pierwsza = false;

                }
                if (pierwsza)
                {
                    return num;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
