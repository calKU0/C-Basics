using System;

namespace Suma_ciągu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Program słuzy do obliczania ciągu arytmetycznego gdzie r=1");
            Console.WriteLine("Podaj 1szy wyraz ciągu: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2gi wyraz ciągu: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Twoje liczby: ");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);

            int i = a;
            int result1 = 0;
            while (i <= b)
            {
                result1 = result1 + i;
                i++;
            }
            Console.WriteLine("Suma ciągu = " + result1);

            int result2 = 0;

            for (int j = a; j<=b; j++)
            {
                result2 = result2 + j;
            }
            Console.WriteLine("Suma ciągu = " + result2);

            int k = a;
            int result3 = 0;
            do
            {
                result3 = result3 + k;
                k++;
            }
            while (k <= b);
            Console.WriteLine("Suma ciągu = " + result3);



        }
    }
}
