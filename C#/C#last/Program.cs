using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            StaticDemo.calc();
            Console.WriteLine(StaticDemo.Amt);
            */
            PartialDemo p=new PartialDemo(1,2,"Raja");
            int ans =p.ans();
            Console.WriteLine(ans);
            p.disp();

            p.calc();
        }
    }
}
