using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* ABSTRACT

            int percent = Convert.ToInt32(Console.ReadLine());
            int accno = Convert.ToInt32(Console.ReadLine());
            string acname = Console.ReadLine();
            double bal = Convert.ToDouble(Console.ReadLine());
            double intamt = Convert.ToDouble(Console.ReadLine());
            CalPart calc=new CalPart(percent,accno,acname,bal,intamt);
            double ans=calc.CalculateIntAmt();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Account no : " + accno);
            Console.WriteLine("Name : "+acname);
            Console.WriteLine("Answer : "+ans);
           */
           /*INTERFACE DEMO-1

           sample2 sam=new sample2();
            sam.display();
            int ans=sam.add1(5, 4);
            Console.WriteLine(ans);
            sam.remove1();

            */

            Animals animals = new Animals("Dog",2,1,1,4);
            animals.MakeSound(animals.Name);
            animals.Type();


        }
    }
}
