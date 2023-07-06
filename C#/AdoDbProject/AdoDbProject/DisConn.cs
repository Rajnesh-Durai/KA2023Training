using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdoDbProject
{
    internal class DisConn:ConfigurationSection
    {
        //getting from AppConfig Connectings ==> String and storing them in a string
        public string conn = ConfigurationManager.ConnectionStrings["Market"].ConnectionString;
        SqlConnection connect;
        SqlDataAdapter adapter;
        DataSet ds;

        //outputs ==> Contains the list of prices of the selected products
        public List<decimal> outputs = new List<decimal>();

        //ans ==> added amount in each department
        public decimal ans = 0;


        public List<decimal> available = new List<decimal>();

        public IList<decimal> updated = new List<decimal>();

        //Openning the Connection
        public void OpenConn()
        {
            try
            {
                connect = new SqlConnection(conn);
                connect.Open();
                //Console.WriteLine("Opened");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Opened");
            }
        }

        public decimal VegTable() 
        {
            adapter = new SqlDataAdapter("select Product,Price,Available_Quantity from ProductsUpdated where Product_Section='Vegetables' ", connect); //Checking in db for Vegetable section
            ds= new DataSet();
            adapter.Fill(ds, "Products");
            Console.WriteLine(); int i = 1;

            //Displaying the list of Products available in Vegetable  Section

            try
            {
                foreach (DataRow row in ds.Tables["Products"].Rows)
                {
                    Console.WriteLine(i++ + "." + row["Product"].ToString() + "     Price : " + row["Price"] + "     Available Amount in Kg : " + row["Available_Quantity"]);
                }
            }
            catch (SqlException e) 
            {
                Console.WriteLine("Values not Fetched properly"); 
            }
            Console.WriteLine();

            Console.Write("Enter Number of Items: ");
            int total=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //list ==> Contains a list of products that are selected by user
            List<string> list = new List<string>();

            //amt ==> Contains a list of No of Kg that the user is going to select
            List<decimal> amt = new List<decimal>();

            for (int k=0; k<total; k++)
            {
                Console.WriteLine("Enter the Products you need");
                list.Add(Console.ReadLine());
                Console.Write("Enter the no of Kg you need:");
                amt.Add(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine();
            }
            connect.Close();
            //UpdateAvailQuantity(list, amt);
            return Add(list,amt);
        }
        public decimal FruitTable()
        {
            adapter = new SqlDataAdapter("select Product,Price,Available_Quantity from ProductsUpdated where Product_Section='Fruits' ", connect);
            ds = new DataSet();
            adapter.Fill(ds, "Products");
            Console.WriteLine();int i= 1;

            try
            {
                foreach (DataRow row in ds.Tables["Products"].Rows)
                {
                    Console.WriteLine(i++ + "." + row["Product"].ToString() + "     Price : " + row["Price"] + "     Available Amount in Kg : " + row["Available_Quantity"]);
                }
            }
           catch(SqlException e) 
            { 
                Console.WriteLine("Values not Fetched properly"); 
            }

            Console.WriteLine();

            Console.Write("Enter Number of Items: ");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            List<string> list = new List<string>();
            List<decimal> amt = new List<decimal>();

            for (int k = 0; k < total; k++)
            {
                Console.WriteLine("Enter the Products you need");
                list.Add(Console.ReadLine());
                Console.Write("Enter the no of Kg you need:");
                amt.Add(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine();
            }
            connect.Close();
            //UpdateAvailQuantity(list, amt);
            return Add(list, amt);
            
        }
        public decimal GroceryTable()
        {
            adapter = new SqlDataAdapter("select Product,Price,Available_Quantity from ProductsUpdated where Product_Section='Grocery' ", connect);
            ds = new DataSet();
            adapter.Fill(ds, "Products");
            Console.WriteLine(); int i= 1;

            try
            {
                foreach (DataRow row in ds.Tables["Products"].Rows)
                {
                    Console.WriteLine(i++ + "." + row["Product"].ToString() + "     Price : " + row["Price"] + "     Available Amount in Kg : " + row["Available_Quantity"]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Values not Fetched properly");
            }

            Console.WriteLine();
            Console.Write("Enter Number of Items: ");
            int total = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            List<string> list = new List<string>();
            List<decimal> amt = new List<decimal>();

            for (int k = 0; k < total; k++)
            {
                Console.WriteLine("Enter the Products you need");
                list.Add(Console.ReadLine());
                Console.Write("Enter the no of Kg/Litre you need:");
                amt.Add(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine();
            }
           // UpdateAvailQuantity(list, amt);
            connect.Close();
            return Add(list, amt);
        }
        public decimal StatTable()
        {
            adapter = new SqlDataAdapter("select Product,Price,Available_Quantity from ProductsUpdated where Product_Section='Stationary' ", connect);
            ds = new DataSet();
            adapter.Fill(ds, "Products");
            Console.WriteLine(); int i = 1;

            try
            {
                foreach (DataRow row in ds.Tables["Products"].Rows)
                {
                    Console.WriteLine(i++ + "." + row["Product"].ToString() + "     Price : " + row["Price"] + "     Available Amount in Kg : " + row["Available_Quantity"]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Values not Fetched properly");
            }

            Console.WriteLine();
            Console.Write("Enter Number of Items: ");
            int total = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            List<decimal> amt = new List<decimal>();

            for (int k = 0; k < total; k++)
            {
                Console.WriteLine("Enter the Products you need");
                list.Add(Console.ReadLine());
                Console.Write("Enter the no of Kg you need:");
                amt.Add(Convert.ToDecimal(Console.ReadLine()));
                Console.WriteLine();
            }
           // UpdateAvailQuantity(list, amt);
            connect.Close();
            return Add(list,amt); 
        }

        //Going to Add the respective amount selected by the User in each section

        public decimal Add(List<string> list, List<decimal> amt)
        {
            //Using this for loop for running the respective no of products selected by user and Checking the string values with db   
            foreach (string item in list)
            {
                string query = string.Format("select Price from ProductsUpdated where Product='{0}'", item);
                adapter = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapter.Fill(ds, "Products");

                //getting the price of each individual products and storing them in a list
                try 
                {
                    foreach (DataRow dr in ds.Tables["Products"].Rows)
                    {
                        outputs.Add((decimal)dr["Price"]);
                    }
                }
                
                catch (Exception e) 
                {
                    Console.WriteLine("Prices are not added to the outputs list");
                }
            }

            //Multiplying the quantity list with price list and adding it

            try
            {
                for (int j = 0; j < outputs.Count; j++)
                {
                    ans += (amt[j] * outputs[j]);
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("Amount is not added properly check again"); 
            }

            return ans;
           
        }

        //THIS CLASS FOR CHANGING THE ITEMS THAT ARE SELECTED BY THE USER
        public decimal ChangeItem(decimal price)
        {
            List<string> changelist = new List<string>();//item
            List<decimal> amt_change = new List<decimal>();//PRICE OF EACH PRDT
            List<decimal> quan= new List<decimal>();//corrected quantity
            decimal crt_price=0;

            Console.Write("Select the number of items need to be Corrected : ");
            int changeitem=Convert.ToInt32(Console.ReadLine());
            for(int j = 0; j < changeitem; j++)
            {
                Console.WriteLine("Enter the Product Name to be Corrected :");
                changelist.Add(Console.ReadLine());
            }
            foreach(string items in changelist)
            {
                string query = string.Format("select Product,Price,Available_Quantity from ProductsUpdated where Product='{0}'", items);
                adapter = new SqlDataAdapter(query, connect);
                ds = new DataSet();
                adapter.Fill(ds, "ProductsFinal");
                foreach (DataRow dr in ds.Tables["ProductsFinal"].Rows)
                {
                    amt_change.Add((decimal)dr["Price"]);
                }
                Console.WriteLine("Enter the Corrected amount of '{0}' you need to decreased from the Selected one: ",items);
                quan.Add(Convert.ToDecimal(Console.ReadLine()));
            }
            
            for(int d=0;d<changeitem;d++)
            {
                try
                {
                    crt_price += (amt_change[d] * quan[d]);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine("Values are not selected properly. Check it Again!!");
                }
            }

            
            return price-crt_price;
        }
    }
}
