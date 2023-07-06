using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoAssessment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("data source=");
            Console.WriteLine("Enter Datasource");
            sb.Append(Console.ReadLine());
            Console.WriteLine("Enter Database");
            sb.Append(";initial catalog=");
            sb.Append(Console.ReadLine());
            sb.Append(";integrated security=SSPI;");

            Assessment assessment = new Assessment();
            assessment.OpenConnec(sb.ToString());
            //assessment.CreateTable();
            //assessment.InsertValue();
            //assessment.Qn1();
            //assessment.Qn2();
            //assessment.Qn3();
            //assessment.Qn4();
            assessment.Qn5();
        }
    }
}