using System;
using System.Linq;

namespace Numbers_Repeat
{
    public static class Extensions
    {
        public static bool find<T>(this T[] array, T target)
        {
            return array.Contains(target);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program is outputting how many times a number apears in an array");
            int[] array = new int[20];
            Random rnd = new Random();

            //Inputing random element to array
            for (int i = 0; i < 20; i++)
            {
                int num = rnd.Next(1, 11);
                array[i] = num;
            }

            //Printing an array
            Console.WriteLine("");
            Console.Write("Array: ");
            foreach (int i in array)
            {
                Console.Write(i+" ");
            }

            //Repeating

            Console.WriteLine("");
            int j = 1;
            int[] repnumbers = new int[10];
            foreach (int k in array)
            {
                if (k == 1)
                {
                    repnumbers[0] += 1;
                }
                else if (k == 2)
                {
                    repnumbers[1] += 1;
                }
                else if (k == 3)
                {
                    repnumbers[2] += 1;
                }
                else if (k == 4)
                {
                    repnumbers[3] += 1;
                }
                else if (k == 5)
                {
                    repnumbers[4] += 1;
                }
                else if (k == 6)
                {
                    repnumbers[5] += 1;
                }
                else if (k == 7)
                {
                    repnumbers[6] += 1;
                }
                else if (k == 8)
                {
                    repnumbers[7] += 1;
                }
                else if (k == 9)
                {
                    repnumbers[8] += 1;
                }
                else
                {
                    repnumbers[9] += 1;
                }
            }
            while (j < 11)
            {
                Console.WriteLine(j + " - "+ repnumbers[j-1]);
                j++;
            }
            

        }
    }
}
