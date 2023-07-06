using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSideProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConnecDB db = new ConnecDB();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("                                            24HRS DEPARTMENTAL STORES");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Welcome Admin!!");
            Console.WriteLine() ;
            Console.WriteLine("Please Enter your UserName and Password");
            Console.WriteLine();

            Boolean answ= db.Admin();
            if (answ) 
            {
                Console.WriteLine("There are 4 sections in our Departmental Stores that Admin need to be updated");
                string output = "";//yes or no
                string? ans = "Yes";
                do
                {
                    Console.WriteLine("It includes:");
                    Console.WriteLine("      1.Add new Products");
                    Console.WriteLine("      2.Remove Existing Product");
                    Console.WriteLine("      3.Update The Price of the Product");
                    Console.WriteLine("      4.Update The Available Amount of the Product");
                    Console.WriteLine();
                    Console.WriteLine("Select any one section from the following");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            db.AddValue();
                            break;
                        case 2:
                            db.DisplayValue();
                            break;
                        case 3:
                            db.UpdatePrice();
                            break;
                        case 4:
                            db.UpdateAvailQuantity();
                            break;

                    }
                    Console.WriteLine("Do you wish to continue? Type Yes or No");
                    output = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                } while (output == ans);
                Console.WriteLine("Thank You for Making some Changes!!");
            }
            else { Console.WriteLine("Check your UserName and Password");}
            
        }
    }
}
