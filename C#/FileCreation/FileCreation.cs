using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileCreation
{
    internal class FileCreation
    {
        public void file() 
        {
            FileInfo fi = new FileInfo("D:\\C#.NET PROGRAMS\\Sample.txt");
            using StreamWriter stwr = fi.CreateText();
            Console.WriteLine("File has been created");
            stwr.WriteLine("Hi there");
            stwr.WriteLine("Welcome to Kanini!!");
        }
        public void DelFile()
        {
            FileInfo fi2 = new FileInfo("D:\\C#.NET PROGRAMS\\SampleDel.txt");
            fi2.Delete();
        }
        public void CopyMoveFile()
        {
            FileInfo fi = new FileInfo("D:\\C#.NET PROGRAMS\\SampleCopy1.txt");
            
            FileInfo fi2 = new FileInfo("D:\\C#.NET PROGRAMS\\SampleCopy2.txt");
            //Copy the 1st file to 2nd
            fi.CopyTo("D:\\C#.NET PROGRAMS\\temp2"+"SampleCopy2.txt");
            //moveto
            fi.MoveTo("D:\\C#.NET PROGRAMS\\temp3" + "Sample.txt");
        }
        public void ReadData()
        {
            FileInfo fi = new FileInfo("D:\\C#.NET PROGRAMS\\SampleDel.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.DirectoryName);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Exists);
        }
    }
}
