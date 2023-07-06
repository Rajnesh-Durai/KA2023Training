using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsPalindrome(number))
            {
                Console.WriteLine(number + " is a palindrome number.");
            }
            else
            {
                Console.WriteLine(number + " is not a palindrome number.");
            }




            Console.ReadKey();
        }
        public static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reverseNumber = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverseNumber = reverseNumber * 10 + remainder;
                number = number / 10;
            }
            return originalNumber == reverseNumber;
        }

    }
}

