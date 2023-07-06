using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cusid = 1;
            long acno = 483217891;
            string acname = "RAJA";
            decimal balan = 650;

            BankTransaction transaction = new BankTransaction(cusid, acno, acname, balan);
            //transaction.GetCustDetails();

            decimal bal=transaction.PaymentProcess();

            Console.WriteLine("NAME: " + acname + " -- BALANCE AMT: " + bal + " -- STATUS:ACTIVE ");


          
        }
    }
}
