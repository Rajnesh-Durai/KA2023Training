using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlstatement
{
    internal class BankTransaction
    {
        public int custid;
        public long accno;
        private string accname, status;
        private decimal debitamt;
        private decimal balance;
        private decimal credamt;

        public decimal Balance { get => balance; set => balance = value; }
        public decimal Credamt { get => credamt; set => credamt = value; }
        public decimal Debitamt { get => debitamt; set => debitamt = value; }

        public BankTransaction(int custid,long accno, string  accname, decimal balance)
        {
            Console.WriteLine("-------------THE DETAILS BELOW-----------");
            this.custid = custid;
            this.accno = accno;
            this.accname = accname;
            this.balance = balance;
            status = "Inactive";
            credamt = debitamt = 0;
            Console.WriteLine("custid: " + custid);
            Console.WriteLine("Accno: " + accno);
            Console.WriteLine("Accname: " + accname);
            Console.WriteLine("Balance: " + balance);
        }
        public decimal PaymentProcess()
        {
            Console.WriteLine("SELECT 1 => CREDIT AND 2 => DEBIT");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the credit amt :");
                    credamt = Convert.ToDecimal(Console.ReadLine());
                    balance += credamt;
                    status = "Active";
                    break;

                case 2:
                    Console.WriteLine("Enter the debit amt :");
                    debitamt = Convert.ToDecimal(Console.ReadLine());
                    balance -= debitamt;
                    status = "Active";
                    break;

                default:
                    Console.WriteLine("Enter 1 or 2");
                    break;
            }
            return balance;
        }

    }
}
