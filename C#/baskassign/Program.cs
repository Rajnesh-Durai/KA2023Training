using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baskassign
{
    public class Ab
    {
        public static void display(int a, int b) { Console.WriteLine("hii"); }
    }
    public class Bc
    {
        public static void display(int a) { Console.WriteLine("hii"); }
    }
    public class Cd
    {
        public static void display(int a, int b) { Console.WriteLine("hii"); }
    }
    public class De
    {
        public static void display1(int a) { Console.WriteLine(""); }
    }
    public delegate void mydel(int a, int b);

    internal class Program
    {
        public void display(int a, int b) { Console.WriteLine("hii"); }
        public  void display2(int a) { Console.WriteLine("hii"); }
        public void display3(int a, int b) { Console.WriteLine("hii2"); }
        public  void display4(int a) { Console.WriteLine(""); }


        static void Main(string[] args)
        {
           /* Ab ab = new Ab();
            Bc bc = new Bc();
            Cd d = new Cd();
            De de = new De()*/
           Program program = new Program();
            mydel obj=new mydel(program.display);
            obj(5,4);
            Console.ReadKey();
        }
    }
}
