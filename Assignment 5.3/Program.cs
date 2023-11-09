using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[5];
            Console.WriteLine("Enter integers:");
            for (int i = 0; i < intarray.Length; i++)
            {
                int j = int.Parse(Console.ReadLine());
                intarray[i] = j;
            }
            Console.WriteLine("Populated array:");
            //foreach (int i in intarray)
            //{
            //    Console.Write(i+" ");
            //}
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.Write(intarray[i] + " ");

            }
            int sum = 0;
            Console.WriteLine("\nSum of the array elements");
            foreach (int i in intarray)
            {

                sum = sum + i;

            }
            Console.WriteLine("\n" + sum);

            double d = sum / intarray.Length;
            Console.WriteLine("Average of the array elements");
            Console.WriteLine("\n" + d);



            Console.ReadKey();
        }

    }
}
      
