using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Overload_1
    {
        private long accno;
        private int custid;
        private string name;
        private double balance;
        private string status;


        public long Accno { get => accno; set => accno = value; }
        public int Custid { get => custid; set => custid = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }

        public Overload_1(long accno,int custid,string name,double balance,string status) 
        {
            this.accno = accno;
            this.custid = custid; this.name = name;
            this.balance = balance;
            this.status = status;
        }
        public void BankDetails(long accno)
        {
            if (accno == Accno)
            {
                custid = Custid;
                name = Name;
                balance = Balance;
                status = Status;
            }
        }
        public void BankDetails(int custid)
        {
            if (custid == Custid)
            {
                accno = Accno;
                name = Name;
                balance = Balance;
                status = Status;
            }
        }
    }
}
