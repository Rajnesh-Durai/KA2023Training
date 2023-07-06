using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class BankDetails
    {
        private int accno;
        private string acname;
        private double bal, intamt;

        public BankDetails(int accno,string acname,double bal,double intamt) 
        { 
            this.accno = accno;
            this.acname = acname;
            this.bal = bal;
            this.intamt = intamt;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Acname { get => acname; set => acname = value; }
        public double Bal { get => bal; set => bal = value; }
        public double Intamt { get => intamt; set => intamt = value; }

        public abstract double CalculateIntAmt();
    }
    internal class CalPart: BankDetails
    {
        private int percent;
        public CalPart(int percent, int accno, string acname, double bal, double intamt):base(accno,acname,bal,intamt)
        {
            this.Percent = percent;
            this.Accno = accno;
            this.Acname = acname;   
            this.Bal = bal;
            this.Intamt = intamt;
        }

        public int Percent { get => percent; set => percent = value; }

        public override double CalculateIntAmt()
        { 
            return (percent*Bal)/100;
        }
    }
}
