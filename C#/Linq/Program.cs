using Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//delegate bool EligibilityCheck(People person);

namespace Linq
{
    /*internal class VoterCheck
    {
        public static List<People> where(People[] peoples,EligibilityCheck del)
        {
            List<People> voters = new List<People>();
            foreach (People person in peoples)
            {
                if (del(person)) 
                {
                    voters.Add(person);
                }
            }
            return voters;
        }
    }*/
    internal class Program
    {
        public static void Main(string[] args)
        {
            // .NET 1.0
            People[] peoples =
            {
                new People{Name="Raja",Age=21 },
                new People{Name="Rajnesh",Age = 45 },
                new People{Name="rajeesh",Age=7}
            };
            /*
            People[] voters = new People [ peoples.Length];
            int i = 0;
            foreach ( People person in peoples )
            {
                if(person.Age>=18)
                {
                    voters[i++] = person;
                    Console.WriteLine(person.Name);
                }
            }

            // .NET 2.0

            Console.WriteLine(".NET 2.0");

            List<People> list = VoterCheck.where(peoples, delegate (People people)
            {
                return people.Age >= 18;
            });
            foreach( People person in list)
            {
                Console.WriteLine(person.Name);
            }*/

            //LINQ 

            List<People> voters=peoples.Where(person=> person.Age >=18).ToList();

            var voter = peoples.Where(person => person.Age >= 18);

            foreach (People person in voters)
            {
                Console.WriteLine(person.Name);
            }

            //-----------------------------------------------

            //WITH QUERY PASSING

            var voters2=(from person in peoples
                                 where person.Age >=18
                                 select person).ToList();
            foreach(var person in voters2)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("-----------------------------");

            ExamplesForClassification ex=new ExamplesForClassification();
            ex.Example1();
            ex.Example2();
            ex.Example3();
            ex.Example4();

            
        }

    }
}
