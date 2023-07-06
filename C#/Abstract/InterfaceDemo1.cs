using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal interface InterfaceDemo1
    {
         int add1(int n1,int n2);
         void remove1();
    }
    internal class sample
    {
        public void display()
        {
            Console.WriteLine("Hii");
        }
    }
    internal class sample2:sample,InterfaceDemo1 
    {
        public int add1(int n1,int n2 )
        {
            Console.WriteLine();
            return n1 + n2;

        }
        public void remove1() 
        {
            Console.WriteLine("Removed...");
        }
    }
}
