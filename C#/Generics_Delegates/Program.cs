using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics_Delegates
{
    public delegate void Mydelegate(string a);

    internal class Program
    {
        static void InvokeDele(Mydelegate m )
        {
            
            m("raja");
        }
        public static void Main(string[] args) 
        {
            //FOR GENERICS CLASS

            /* Console.WriteLine("Enter a number:");
             int num=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a number2 :");
             int num2 = Convert.ToInt32(Console.ReadLine());

             Generics<int> gen = new Generics<int>(num, num2);

             int ans = gen.ans();
             Console.WriteLine("------------------------------------------");
             Console.WriteLine(ans); */

            // FOR GENERIC_ARRAY

            /* Generic_Array<int> generic_Array = new Generic_Array<int>(5); //within the bracket is constructor part

             for(int i=0; i<5; i++)
             {
                 generic_Array.setarr(i, i*10);
             }
             for(int i=0; i<5;i++)
             {
                 Console.WriteLine(generic_Array.OutArr(i));
             }*/

            /*

            //GENERIC EXCEPTION

            Generic_Exception<ArithmeticException> generic_Exception = new Generic_Exception<ArithmeticException>(arithmeticException);
            Console.WriteLine(generic_Exception.Display().Message);
            */

            //DELEGATE

            /*
            Delegate del = new Delegate();//class declaration
            Mydelegate mydelegate, mydelegate2;// creating a obj for delegate

            mydelegate = del.add;
            int ans = mydelegate(5, 6);
            Console.WriteLine(ans);

            mydelegate2 = del.sub;          
            int ans2 = mydelegate2(10, 12);
            Console.WriteLine(ans2);
            */
            invokedele invoke = new invokedele();
            Mydelegate mydelegate=invoke.disp;
            
            InvokeDele(mydelegate);
        }
    }
}
