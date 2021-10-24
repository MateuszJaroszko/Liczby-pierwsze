using System;

namespace Liczby_pierwsze
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb pierwszych chcesz wyświetlić na ekranie:");
            int ile = Convert.ToInt32(Console.ReadLine()); /*Pobieramy od użytkownika ile chcemy liczb rzeczywistych wypisać na ekranie*/
            int i = 0; /*zmienna zastępująca i z pętli for*/
            int counter = 0; /*Zmienna pomocnicza do zliczania ile jest wystąpień liczb pierwszych*/
            Console.WriteLine("To twoje liczby pierwsze:");
            while (counter <ile) /*pętla while która wypisuje liczby pierwsze dopóki counter nie będzie taki sam jak liczba podana przez użytkownika*/
            {
                int wynik = czyPierwsza(i); /*użycie funkcji czyPierwsza*/
                i += 1;
                if (wynik != 0) /*Funkcja czyPierwsza zwraca nam zera i liczby pierwsze więc żeby wyświetlić liczby pierwsze wynik musi być różny od zera*/
                {
                    counter += 1;/*po każdym wypisaniu dodajemy jeden*/
                    Console.Write(wynik+" ");
                }
            }
        } 
        public static int czyPierwsza(int num)
        {
            bool pierwsza = true; 
            for (int i = 2; i <=num; i++) /*pętla for działa dopóki i będzie mniejsze bądź równe num*/
            {
                if (num == 2) /*warunek do wyświetlenia także 2 jako liczby pierwszej*/
                {
                    return num;
                }
                if (num % i == 0)/*sprawdzenie czy jest to liczba pierwsza*/
                {
                    pierwsza = false; /*nie jest to liczba pierwsza*/

                }
                if (pierwsza)
                {
                    return num;/*zwraca liczbę pierwszą*/
                }
                else
                {
                    return 0;/*jeżeli nie jest liczbą pierwszą zwracamy 0*/
                }
            }
            return 0;/*cała funkcja zwraca zero, ponieważ nie mogła by być wtedy int*/
        }
    }
}
