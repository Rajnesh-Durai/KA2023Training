
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileCreation
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            FileCreate filecrt = new FileCreate();
            filecrt.Writefile(); 
        }
    }
}