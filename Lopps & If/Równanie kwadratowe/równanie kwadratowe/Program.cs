using System;

namespace równanie_kwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Program służy do obliczania pierwiatków równania kwadratowego ax^2+bx+c");
            Console.WriteLine("Podaj liczbę a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę c:");
            c = double.Parse(Console.ReadLine());

            double delta = b * b + (-4 * a * c);

            if (a > 0 & delta>0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2*a);
                double x2 = (-b - Math.Sqrt(delta)) / (2*a);
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);
                if (c < 0)
                {
                    Console.WriteLine("Delta = " + b + "^2" + "-" + "4*" + a + "*" + "(" + c + ")");
                }
                else if (a<0)
                {
                    Console.WriteLine("Delta = " + b + "^2" + "-" + "4*" + "(" + a + ")" + "*" + c);
                    Console.WriteLine("Delta = " + delta);
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }

            }
            else if (a==0)
            {
                Console.WriteLine("To nie jest równanie kwadratowe");
            }

            else if (delta<0)
            {
                Console.WriteLine("Delta = " + b + "^2" + "-" + "4*" + a + "*" + c);
                Console.WriteLine("Delta = " + delta);
                Console.WriteLine("Równanie nie ma rozwiązań");
            }

            else if (delta==0)
            { 
                double x0 = -b / (2 * a);
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);
                Console.WriteLine("Delta = " + b + "^2" + "-" + "4*" + a + "*" + c);
                Console.WriteLine("Delta = " + delta);
                Console.WriteLine("Równanie ma jedno rozwiązanie = " + x0);

            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
                Console.WriteLine("c = " + c);
                Console.WriteLine("Delta = " + b + "^2" + "-" + "4*" + "(" + a + ")" + "*" + c);
                Console.WriteLine("Delta = " + delta);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}
