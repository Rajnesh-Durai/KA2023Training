using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Mutiple2:College
    {
        private string name2;
        private int eid1;
        private double salary2;

        public Mutiple2(string collegename,string addr,int pin,string name2,int eid1, double salary2):base(collegename,addr,pin) 
        {
            this.name2 = name2;
            this.eid1 = eid1;
            this.salary2 = salary2;
        }

        public string Name2 { get => name2; set => name2 = value; }
        public int Eid1 { get => eid1; set => eid1 = value; }
        public double Salary2 { get => salary2; set => salary2 = value; }

        public double CalSal2()
        {
            double da = 0.2;
            double hra = 0.6; double allowance = (salary2 * da) + (salary2 * hra);
            double pf = 0.15;
            double dedec = salary2 * pf;
            double netpay = salary2 + allowance - dedec;
            return netpay;
        }
    }
}
