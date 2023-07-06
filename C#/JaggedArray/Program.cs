using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //SINGLE DIMENSION

            int[][] jarray = new int[4][];
            jarray[0] = new int[4] { 0, 8, 3, 6 };
            jarray[1] = new int[1] { 1 };
            jarray[2] = new int[2] { 2 ,300};
            jarray[3] = new int[3] { 7, 65, 42 };

            Console.WriteLine(jarray[3][1]);

            for(int i=0;i<jarray.Length;i++) 
            {
                for(int j = 0; j < jarray[i].Length;j++)
                {
                    Console.Write(jarray[i][j]+" ");
                }
                Console.WriteLine();
            }
            */

            /*
             * 
            //MULTI DIMENSION

            //follow rank similar to matrix => only same order is to be in 2D Array

            int[][,] jarray = new int[4][,]
            {
                new int[,] { {5,8 },{ 6,2} },
                new int[,] { {5,1 } ,{ 5,3} },
                new int[,] { {3 ,5},{ 0,2} },
                new int[,] { {8 ,8},{1,2} }
            };

            Console.WriteLine(jarray[3][1,1]);

            for (int i = 0; i < jarray.Length; i++) 
            {
                int x = 0;
                for(int j = 0; j < jarray[i].GetLength(x); j++)
                {
                    //Console.Write(jarray );
                    for (int k = 0;k< jarray[j].Rank;k++)
                    {
                        Console.Write(jarray[i][j, k]+" ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
            */

           /* Lambda lambda = new Lambda();
            lambda.evennum();
           */
           ans ans = new ans();
            ans.disp();
            ans.dog();
        }
    }
}
