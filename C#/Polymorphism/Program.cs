using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cid = 1;
            long acno = 789465;
            string names = "RAJA";
            double bal = 7984.84;
            string status = "Inactive";
            Overload_1 overload=new Overload_1(acno,cid,names,bal,status);
            Console.WriteLine("Select 1 =>  and2 => ");
            int ch=Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    overload.BankDetails(acno);
                    Console.WriteLine(overload.Custid + " "+overload.Balance + " " + overload.Name + " " + overload.Status);
                    break;
                case 2:
                    overload.BankDetails(cid);
                    Console.WriteLine(overload.Accno + " " + overload.Balance + " " + overload.Name + " " + overload.Status);

                    break;
            }
        }
    }
}
