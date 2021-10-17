using System;

namespace Liczby_pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            
            licz(Convert.ToInt32(Console.ReadLine())); 
        static void licz(int num)
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
                            Console.WriteLine("Jest liczbą pierwszą");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nie jest liczbą pierwszą");
                            break;
                        }
                    }
                
            }
        }

    }
}
