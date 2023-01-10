using System;
using System.Linq;

namespace BasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operating on arrays");
            int[] array = new int[10];
            Random rnd = new Random();

            //Inputing random element to array
            for(int i=0; i<10; i++)
            {
                int num = rnd.Next(-10, 10);
                array[i] = num;
            }
            Console.WriteLine("");

            //Printing array
            Console.WriteLine("Random selected numbers: ");
            foreach (int j in array) 
            {
                Console.Write(j+", ");
            }
            Console.WriteLine("");

            //Min & Max
            int min = array.Min();
            int max = array.Max();
            Console.WriteLine("");
            Console.WriteLine("Min: "+min+", Max: "+max);
            Console.WriteLine("");

            //Arithmetic mean
            int sum = 0;
            foreach(int k in array)
            {
                sum += k;
            }
            int armean = sum / array.Length;
            Console.WriteLine("Arithmetic mean: "+armean);
            Console.WriteLine("");

            //Lower and higher than arethemtic mean
            int lower = 0;
            int higher = 0;
            int equal = 0;
            for (int l=0; l < array.Length; l++)
            {
                if (array[l] < armean)
                {
                    lower++;
                }
                else if (array[l] > armean)
                {
                    higher++;
                }
                else
                {
                    equal++;
                }
            }
            Console.WriteLine("Number of elements lower than arithmetic mean(" + armean + ")" + ": " + lower);
            Console.WriteLine("Number of elements higher than arithmetic mean(" + armean +")"+ ": " + higher);
            Console.WriteLine("Number of elements higher equal to arithmetic mean(" + armean + ")" + ": " + equal);
            Console.WriteLine("");

            //Printing elements of array in reverse
            int y = array.Length;
            int x = y - 1;
            Console.WriteLine("Random selected numbers in reverse: ");
            while (x>=0)
            {
                Console.Write(array[x] + ", ");
                x--;
            }
                
        }
    }
}
