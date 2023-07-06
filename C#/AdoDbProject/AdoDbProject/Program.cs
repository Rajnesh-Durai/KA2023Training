using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDbProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("                                            24HRS DEPARTMENTAL STORES");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("There are 4 sections in our Departmental Stores"); string? ans = "Yes";
            string output="";
            decimal price = 0; //gets added values from each section and adding them
            do {
                Console.WriteLine("It includes:");
                Console.WriteLine("      1.Vegetable section");
                Console.WriteLine("      2.Fruit section");
                Console.WriteLine("      3.Grocery section");
                Console.WriteLine("      4.Stationay section");
                Console.WriteLine();
                Console.WriteLine("Select any one section from the following");


                int choice = Convert.ToInt32(Console.ReadLine());
                DisConn disConn = new DisConn();
                disConn.OpenConn();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Here is the List of Vegetables Available");
                        price+=disConn.VegTable();
                        break;
                    case 2:
                        Console.WriteLine("Here is the List of Fruits available");
                        price+=disConn.FruitTable();
                        break;
                    case 3:
                        Console.WriteLine("Here is the List of Groceries available");
                        price += disConn.GroceryTable();
                        break;
                    case 4:
                        Console.WriteLine("Here is the List of Stationary Items available");
                        price += disConn.StatTable();
                        break;
                }
                Console.WriteLine("Do you wish to continue? Type Yes or No");
                 output = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                if (output == "No")
                {
                    Console.WriteLine("Total Bill Amount: Rs."+price);
                }
                // disConn.UpdateAvailQuantity();

                
            } while(output==ans);
            Console.WriteLine("Do you need to cancel any order from any selected");
            string wish = Console.ReadLine();
            decimal final_amt;
            DisConn disConn2 = new DisConn();
            disConn2.OpenConn();
            if (wish == "Yes")
            {
                final_amt = disConn2.ChangeItem(price);
                Console.WriteLine("Corrected Bill: Rs." + final_amt);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thank You For Purchasing!!!");
            }
        }
    }
}
