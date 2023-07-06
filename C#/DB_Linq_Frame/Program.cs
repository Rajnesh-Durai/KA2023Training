using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Linq_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassDBContext db = new ClassDBContext();
            //db.ReadDataFromSqlServer();
            //db.CountMinMaxAvg();
            db.Join();
            Console.ReadKey();
        }
    }
}
