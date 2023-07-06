using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Controlstatement
{
    internal class Type
    {
        public void practice()
        {
            Console.WriteLine("TYPE A OR D");
            Char choice=Convert.ToChar(Console.ReadLine());
            if (choice == 'A')
            {
                int limit,i,j;
                limit = Convert.ToInt32(Console.ReadLine());
                int[] array1= new int[limit];
                for(i=0;i<limit;i++)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());    
                }
                for (i = 0; i < limit; i++)
                {
                    for(j=i+1;j<limit;j++)
                    {
                        if (array1[i] > array1[j])
                        {
                            int temp = array1[i];
                            array1[i] = array1[j];
                            array1[j] = temp;
                        }
                    }
                }
                Console.WriteLine(string.Join(",", array1));
            }
            else
            {
                int limit, i, j;
                limit = Convert.ToInt32(Console.ReadLine());
                int[] array1 = new int[limit];
                for (i = 0; i < limit; i++)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (i = 0; i < limit; i++)
                {
                    for (j = i + 1; j < limit; j++)
                    {
                        if (array1[i] < array1[j])
                        {
                            int temp = array1[i];
                            array1[i] = array1[j];
                            array1[j] = temp;
                        }
                    }
                }
                Console.WriteLine(string.Join(",", array1));
            }

        }
        internal void loopfn()
        {
            int no = 3,c=0;
            do
            {
                c++;no++;
            }while(no <= 10);
            Console.WriteLine(c);
        }
    }
}
