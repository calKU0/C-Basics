using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Program sprawdza czy podane liczbe tworzą trójke pitagorejską");
            Console.WriteLine("Podaj liczbę a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c");
            c = int.Parse(Console.ReadLine());

            if (a*a+b*b == c*c)
            {
                Console.WriteLine("Liczby: ");
                Console.WriteLine("a = "+a);
                Console.WriteLine("b = "+b);
                Console.WriteLine("c = "+c);
                Console.WriteLine("Podane liczby tworzą trójkąt pitagorejski ");
            }
            else
            {
                Console.WriteLine("Liczby: ");
                Console.WriteLine("a = " + a + ", ");
                Console.WriteLine("b = " + b + ", ");
                Console.WriteLine("c = " + c);
                Console.WriteLine("Podane liczby nie tworzą trójkąt pitagorejski ");
            }

        }
    }
}
