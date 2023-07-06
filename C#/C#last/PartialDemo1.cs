using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_last
{
    partial class PartialDemo
    {
        private int n1, n2;

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        public PartialDemo(int n1, int n2) 
        {
            N1 = n1; 
            N2 = n2;
        }
        public int ans() 
        {
            return n1+n2;
        }
        public partial void calc();
       
    }

    partial class PartialDemo
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public PartialDemo(int n1, int n2, string name)
        {
            N1 = n1;
            N2 = n2;
            Name = name;
        }
        public void disp() { Console.WriteLine(Name); }
        public partial void calc()
        {
            Console.WriteLine(n1-n2);

        }
    }
}
