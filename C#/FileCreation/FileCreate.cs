using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreation
{
    internal class FileCreate
    {
        public void file()
        {
            //CREATING ALL YEAR FILE WITH YEARS FROM 2000 TO 2050

            FileInfo fi = new FileInfo("D:\\C#.NET PROGRAMS\\All_Years.txt");
            using StreamWriter stwr = fi.CreateText();
            Console.WriteLine("File has been created");
            for (int i = 1950; i < 2050; i++)
            {
                stwr.WriteLine(i);
            }
        }
        public void Readfile()
        {
            

            string file_details = "D:\\C#.NET PROGRAMS\\All_Years.txt";
            try
            {
                StreamReader sr = new StreamReader(file_details);
                string text = File.ReadAllText(file_details);
                Console.WriteLine(text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        public void Writefile()
        {
            FileStream fs = new FileStream("D:\\C#.NET PROGRAMS\\All_Years.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            fs = new FileStream("D:\\C#.NET PROGRAMS\\Leap_Years.txt", FileMode.Create, FileAccess.Write);
            StreamWriter swLeapYear = new StreamWriter(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int year = int.Parse(line);

                if (year % 4 == 0)
                {
                    swLeapYear.WriteLine(year);
                }
            }
            swLeapYear.Close();


        }
    }
}
