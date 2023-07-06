using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Delegates
{
    internal class Delegate
    {
        

        public int add(int num1,int num2)
        {
            num1++; num2++; Console.WriteLine( num2+num1);
            return num1;//6+7=13 || 6
        }

        public int sub(int num1,int num2)
        {
            Console.WriteLine();
            num1--; num2--; Console.WriteLine( num2 - num1);
            
            return num2;//5-4=1  || 5
        }
    }
}
