using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int accno=Convert.ToInt32(Console.ReadLine());
            string acname=Console.ReadLine();
            double bal=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Credited amt:");
            double creditamt=Convert.ToDouble(Console.ReadLine());
            Bank bank = new Bank(accno, acname, bal, creditamt);
            double ans = bank.BankDetails();
            Console.WriteLine(ans);
        }
    }
}
