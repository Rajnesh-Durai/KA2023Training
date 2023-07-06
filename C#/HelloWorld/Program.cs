using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int n, i;
             n=Convert.ToInt32(Console.ReadLine());
             int[] A = new int[n];
             for (i = 0; i < A.Length; i++)
             {
                 A[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine();
             Console.Write(String.Join(",", A));*/




            int a = 10;
            unsafe
            {
                int* p;
                p = &a;
                Console.WriteLine("P:" + *p);
                Console.WriteLine("address of a:" +(int)p);
            }
            Console.ReadKey();
            
        }
    }
}
