using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            double decimal0;
            int[] binary = new int[32];
            Console.WriteLine("This program will allow you to convert decimal number to binary number");
            Console.WriteLine("");
            Console.Write("Enter your decimal number: ");
            decimal0 = int.Parse(Console.ReadLine());

            int i = 0;
            while(decimal0 != 0)
            {
                if (decimal0 % 2 == 0)
                {
                    binary[i] = 0;
                    decimal0 = decimal0 / 2;
                    i++;
                }
                else
                {
                    binary[i] = 1;
                    decimal0 = (decimal0 / 2) - 0.5;
                    i++;
                }
            }

            while (i>=0)
            {
                Console.Write(binary[i]);
                i--;
            }


        }
    }
}
