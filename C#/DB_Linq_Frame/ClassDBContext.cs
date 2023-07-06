using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Linq_Frame
{
    internal class ClassDBContext
    {
        //DataContext ==> Contains all information about db
        DataClasses1DataContext dataClass1 = new DataClasses1DataContext();
        

        public void ReadDataFromSqlServer()
        {
            
            var dc = from dcs in dataClass1.stud_table1s where dcs.rollno > 102 select dcs;
            foreach (var dcs in dc)
            {
                Console.WriteLine(dcs.rollno + " " + dcs.stud_name);
            }


            Console.WriteLine("------------------------");
            //----------------------------------------------------------------------------

            var meth2 = dataClass1.stud_table1s.First(d => d.rollno == 101);
            var meth = dataClass1.stud_table1s.Where(d => d.rollno > 101);
            foreach (var dcs in meth)
            {
                Console.WriteLine(dcs.stud_name + ": " + dcs.rollno);
            }
        }

        public void CountMinMaxAvg()
        {
           // int count= dataClass1.stud_table1s.Count(s=>s.rollno);
            var coun= (from c in dataClass1.stud_table1s where c.rollno>103 select c).Count();
            Console.WriteLine("Count:"+coun);

            int? mini2=(from c in dataClass1.stud_table1s select c.rollno).Min();
            Console.WriteLine("Min: " + mini2);

            var max = (from c in dataClass1.stud_table1s select c.rollno).Max();
            Console.WriteLine("Max: " + max);


            var min1= dataClass1.stud_table1s.Min(s=>s.rollno);
            var max1=dataClass1.stud_table1s.Max(s=>s.rollno);
            double? avg1=dataClass1.stud_table1s.Average(s=>s.rollno);
            Console.WriteLine("Avg:"+avg1);
        }

        public void Join()
        {
            var ans = dataClass1.Customer_Nodes.Join(dataClass1.Regions,
                a => a.Region_id,
                b => b.Region_id,
                (a, b) => new
                {
                    regname= a.Customer_id,coun=a.Region_id,
                    regid= b.Region_id
                }
                );
            foreach(var reg in  ans)
            {
                Console.WriteLine(reg.regid+" "+reg.regname+"   "+reg.coun);
            }
        }
    }
}
