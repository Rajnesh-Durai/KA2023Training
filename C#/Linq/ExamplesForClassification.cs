using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class ExamplesForClassification
    {
        public void Example1() 
        {
            IList<string> courses = new List<string>() {
                "C++","C#","JAVA",".NET"
            };
            var selected=courses.Where(obj=>obj.StartsWith("C")).ToList();
            foreach (var course in selected)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("---------");

            var selected2=courses.Where(obj=>obj.Contains("AV"));
            foreach (var course in selected2)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("---------");
        }
        public void Example2()
        {
            //STUDENT
            IList<Student> students = new List<Student>()
            {
                new Student(){Studentid=1,Name="raja",Age=34},
                new Student(){Studentid=2,Name="rajnesh",Age=14},
                new Student(){Studentid=3,Name="rajeesh",Age=27},
                new Student(){Studentid=4,Name="laxmeesh",Age=44},
                new Student(){Studentid=5,Name="haseena",Age=4}
            };

            var filter = from person in students where person.Age >= 18 select person;
            var filter2= students.Where(obj=> obj.Age >= 18).ToList();

            foreach (var person in filter)
            {
                Console.WriteLine(person.Name, person.Studentid);
            }
            Console.WriteLine("--------");
        }
        public void Example3()
        {
            IList element = new ArrayList();
            element.Add(0);
            element.Add("Rajnesh");
            element.Add("54");

            var ans = element.OfType<string>().ToList();

            foreach(var element2 in ans) { 
                Console.WriteLine(element2);
            }
            Console.WriteLine("--------");
        }
        public void Example4()
        {
            IList<Student> students = new List<Student>()
            {
                new Student(){Studentid=1,Name="raja",Age=34},
                new Student(){Studentid=2,Name="rajeesh",Age=54},
                new Student(){Studentid=3,Name="rajeesh",Age=27},
                new Student(){Studentid=4,Name="laxmeesh",Age=44},
                new Student(){Studentid=5,Name="haseena",Age=4}
            };

            //SORTING

            var sortin= students.OrderBy(s=> s.Name).ThenBy(s=>s.Age);

            var sorting =from std in students orderby std.Name descending select std;

            foreach (var student in sortin)
            {
                Console.WriteLine(student.Name + " " + student.Age);
            }
            Console.WriteLine("--------");

            //GROUPING

            var group1=from grp in students group grp by grp.Name;

            var group2= students.GroupBy(s=>s.Name).ToList();

            foreach (var student in group2)
            {
                Console.WriteLine(student.Key);
            }
            Console.WriteLine("--------");

            //LOOKUP ==> similar to groupby but "prefer lookup"

            var lookup=students.ToLookup(s => s.Name);
            foreach (var student in group2)
            {
                Console.WriteLine(student.Key);
            }
            Console.WriteLine("--------");
        }
    }
}
