using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class College
    {
        private string collegename, addr;
        private int pin;
        public College(string collegename,string addr, int pin)
        {
            this.collegename = collegename;
            this.addr = addr;
            this.pin = pin;
        }
        public string Collegename { get => collegename; set => collegename = value; }
        public string Addr { get => addr; set => addr = value; }
        public int Pin { get => pin; set => pin = value; }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            //SINGLE INHERITANCE && MUTLI-LEVEL

            /*
            int rollno = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());
            calculate cal= new calculate(rollno, name, m1, m2, m3,0,0);
            int TOTAL= cal.calculation1();
            double AVG=cal.calculation2();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Rollno: " + cal.Rollno);
            Console.WriteLine("Name: "+cal.Name);
            Console.WriteLine("Total: " + TOTAL);
            Console.WriteLine("Average: " + AVG);
            */
            /*
            int rollno = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());
            calculate cal = new calculate(rollno, name, m1, m2, m3, 0, 0);
            int TOTAL = cal.calculation1();
            double AVG = cal.calculation2();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Rollno: " + cal.Rollno);
            Console.WriteLine("Name: " + cal.Name);
            Console.WriteLine("Total: " + TOTAL);
            Console.WriteLine("Average: " + AVG);
            */
            string collegename=Console.ReadLine();
            string addr=Console.ReadLine(); 
            int pin=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter the following for Teaching staff.........");            
            int eid=Convert.ToInt32(Console.ReadLine());
            string name1=Console.ReadLine();
            string dept=Console.ReadLine();
            string favsub=Console.ReadLine();
            double salary=Convert.ToDouble(Console.ReadLine());

            multiple1 mul1=new multiple1(collegename,addr,pin,eid,name1,dept,favsub,salary);
            double ans1=mul1.Calsal1();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("EID:" +mul1.Eid);
            Console.WriteLine("Name: "+mul1.Name1);
            Console.WriteLine("Dept:"+mul1.Dept);
            Console.WriteLine("Hands-on-Salary for Teachers : "+ans1);


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Enter the following for Admin staff.........");

            int eid1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            double salary2 = Convert.ToDouble(Console.ReadLine());

            Mutiple2 mul2 = new Mutiple2(collegename, addr, pin, name2, eid1,salary2);
            double ans2 = mul2.CalSal2();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("EID:" + mul2.Eid1);
            Console.WriteLine("Name: " + mul2.Name2);
            Console.WriteLine("Hands-on-Salary for Admin : "+ans2);
            Console.ReadKey();   

        }
    }
}
