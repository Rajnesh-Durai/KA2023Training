using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal abstract class Abstract1
    {
        public abstract double BankDetails();
    }
    internal class Bank:Abstract1
    {
        private int accno;
        private string acname;
        private double bal;
        private double creditamt;

        public int Accno { get => accno; set => accno = value; }
        public string Acname { get => acname; set => acname = value; }
        public double Bal { get => bal; set => bal = value; }
        public double Creditamt { get => creditamt; set => creditamt = value; }

        public Bank(int accno, string acname, double bal, double creditamt)
        {
            Accno = accno;
            Acname = acname;
            Bal = bal;
            Creditamt = creditamt;
        }

        public override double BankDetails()
        {

            Creditamt = Bal + Creditamt;
            return Creditamt;
        }
        
    }


}
