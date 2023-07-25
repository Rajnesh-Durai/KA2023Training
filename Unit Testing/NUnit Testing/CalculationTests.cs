using NUnit.Framework;
using Calculator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUnitTest
{
    [TestFixture]
    internal class CalculationTests
    {
        private Class1? calc;
        [SetUp] 
        public void SetUp() 
        {
            calc = new Class1(100, 25);
        }

        [TestCase(Author="Rajnesh")]
        [Order(1)]
        public void AddTest()
        {
            int res=calc.Add();
            Assert.AreEqual(125, res);
        }

        [TestCase(10,35)]
/*        [Ignore("In Progress",Until ="2023-08-13")]*/
        [Order(0)]
        public void SubTest(int n1,int n2)
        {
            calc = new Class1(n1,n2);
            int res2 = calc.Sub();
            Assert.AreEqual(-25, res2);
        }

        [TearDown]
        public void CloseTest()
        {
            Console.WriteLine("TearDown");
            calc = null;
        }
    }
}
