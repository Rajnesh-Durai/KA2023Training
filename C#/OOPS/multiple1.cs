using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class multiple1:College
    {
        private int eid;
        private string name1, dept, favsub;
        private double salary;

        public multiple1(string collegename,string addr,int pin,int eid, string name1, string dept, string favsub, double salary):base(collegename, addr, pin) { 
            this.Eid = eid;
            this.Name1 = name1;
            this.Dept = dept;
            this.Favsub = favsub;
            this.Salary = salary;
            
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name1 { get => name1; set => name1 = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Favsub { get => favsub; set => favsub = value; }
        public double Salary { get => salary; set => salary = value; }


        public double Calsal1()
        {
            double da = 0.4;
            double hra = 0.2;double allowance = (salary * da) + (salary * hra);
            double pf = 0.25;
            double dedec=salary * pf;
            double netpay = salary + allowance - dedec;
            return netpay;
        }
    }
}
