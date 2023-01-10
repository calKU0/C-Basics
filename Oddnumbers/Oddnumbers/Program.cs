using System;

namespace Oddnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("The program will display all the odd numbers in range (x,y)");
            Console.WriteLine("Enter x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            y = int.Parse(Console.ReadLine());
            int i = x;
            Console.WriteLine("Odd Numbers in range: "+x+" - "+y);
            if (x % 2 == 0) 
            {
                while (i < y)
                {
                    Console.WriteLine(i+1);
                    i+=2;
             
                }
            }
            else
            {
                while (i < y)
                {
                    Console.WriteLine(i);
                    i += 2;

                }
            }
        }
    }
}
