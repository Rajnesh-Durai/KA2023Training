using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Coordinate
    {
        public void calculate(int x, int y)
        {
            if(x < 0 && y<0) 
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Third quadrant.");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Second quadrant.");
            }
            else
            {
                Console.WriteLine("The coordinate point (" + x + "," + y + ") lies in the Fourth quadrant.");
            }
        }

    }
    internal class Marks
    {
        public void calc(int roll,string name, int phy, int chem, int comp)
        {
            Console.WriteLine("Roll No :" + roll);
            Console.WriteLine("Name of Student : "+name);
            Console.WriteLine("Marks in Physics :  "+phy);
            Console.WriteLine("Marks in Chemistry: "+chem); 
            Console.WriteLine("Marks in Computer Application:" + comp);
            int total = phy + chem + comp;
            Console.WriteLine("Total: " + total);
            decimal percent = total / 3;
            Console.WriteLine("Percentage: " + percent);
            string div;
            if (percent >= 80)
            {
                div = "first";
                Console.WriteLine("Division: " + div);
            }
            if (percent >= 70 && percent<80)
            {
                div = "second";
                Console.WriteLine("Division: " + div);
            }
        }
    }
    
}
