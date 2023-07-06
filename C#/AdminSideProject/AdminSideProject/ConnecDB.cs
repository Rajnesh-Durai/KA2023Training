using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSideProject
{
    internal class ConnecDB:ConfigurationSection
    {
        //getting from AppConfig Connectings ==> String and storing them in a string
        public string conn = ConfigurationManager.ConnectionStrings["Market"].ConnectionString;

        //list of Prdt Section for Adding
        List<string> PrdtSec = new List<string>();

        //list of Prdt for Adding
        List<string> PrdtName = new List<string>();

        //list of Price of the product for Adding
        List<decimal> price = new List<decimal>();

        //list of Available Prdt for Adding
        List<decimal> availPrdt = new List<decimal>();

        SqlConnection connect;

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
        public Boolean Admin()
        {
            OpenConn();
            
            string outs="";
            Console.Write("UserName : ");
            string username=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Password : ");
             string passwrd=Console.ReadLine();
            Console.WriteLine();
            try
            {
                string query = string.Format("select * from AdminDetails where UserName='" + username + "' and Passwords='" + passwrd + "'");
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Welcome Back Admin!!");
                Console.WriteLine(); return true;

            }

            catch (InvalidDataException ex)
            {
                Console.WriteLine("Check Properly!!");
                return false;
            }
            
            CloseConn();
           
                
        }
        //Inserting new Products into DB
        public void AddValue()
        {
            OpenConn();
            Console.Write("Enter number of Items need to be inserted: ");
            int totitems=Convert.ToInt32(Console.ReadLine());

            for(int j=0; j<totitems; j++)
            {
                Console.WriteLine("Enter the Product Section in which the Product need to be inserted");
                PrdtSec.Add(Console.ReadLine());

                Console.WriteLine("Enter the Product Name to be inserted");
                PrdtName.Add(Console.ReadLine());

                Console.WriteLine("Enter the Price of that Product");
                price.Add(Convert.ToDecimal(Console.ReadLine()));

                Console.WriteLine("Enter the Available Quantity of that product");
                availPrdt.Add(Convert.ToDecimal(Console.ReadLine()));


            }
            try
            {
                for (int k = 0; k < totitems; k++)
                {
                    string query = string.Format("insert into ProductsUpdated (Product_Section,Product,Price,Available_Quantity) Values ('" + PrdtSec[k] + "','" + PrdtName[k] + "'," + price[k] + "," + availPrdt[k] + " )");
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Values got inserted");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Not Inserted");
            }
            CloseConn();
        }
        //Displaying the whole table
        public void DisplayValue()
        {
            //PRINT THE OVERALL DB
            OpenConn();
            SqlCommand cmd = new SqlCommand("select * from ProductsUpdated", connect);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["ProductID"] + ".  " + sdr["Product_Section"] + " " + sdr["Product"] + "  " + sdr["Price"] + " " + sdr["Available_Quantity"]);
                }
            }
            else
            {
                Console.WriteLine("The Table is empty...");
            }
            CloseConn();
            DeleteValue();
        }
        //DELETING A PARTICULAR VALUE
        public void DeleteValue() 
        {
            OpenConn();
            Console.Write("Select the number so that particular row can be deleted:");
            int opt = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(opt);
            //AFTER DELETING THE ROW 
            try
            {
                string query = string.Format("delete from ProductsUpdated where ProductID=" + opt); Console.WriteLine(opt);
                SqlCommand cmd2 = new SqlCommand(query, connect);
                cmd2.ExecuteNonQuery();
                Console.WriteLine("Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Deleted");
            }
            CloseConn();
        }
        //UPDATING THE PRICE
        public void UpdatePrice()
        {
            OpenConn();
            Console.Write("Enter the number of item's value need to be updated:");
            int numValue= Convert.ToInt16(Console.ReadLine());
            for(int i = 0; i < numValue; i++)
            {
                Console.WriteLine("Enter the Product Name need to be Updated");
                PrdtName.Add(Console.ReadLine());

                Console.WriteLine("Enter the Price of that Product");
                price.Add( Convert.ToInt32(Console.ReadLine()));
            }
            for(int j = 0;j < numValue; j++)
            {
                try
                {
                    string query = string.Format("update ProductsUpdated set Price='" + price[j] + "'" + " where Product='" + PrdtName[j] + "'");
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Check Properly");
                }
            }
            Console.WriteLine("Values Updated Successfully!!");
            CloseConn();
        }
        //UPDATE VALUES OF AVAILABLE QUANTITY
        public void UpdateAvailQuantity()
        {
            OpenConn();
            Console.Write("Enter the number of item's value need to be updated:");
            int numValue = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numValue; i++)
            {
                Console.WriteLine("Enter the Product Name need to be Updated");
                PrdtName.Add(Console.ReadLine());

                Console.WriteLine("Enter the Available Quantity of that Product");
                availPrdt.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int j = 0; j < numValue; j++)
            {
                try
                {
                    string query = string.Format("update ProductsUpdated set Available_Quantity='" + availPrdt[j] + "'" + " where Product='" + PrdtName[j] + "'");
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    Console.WriteLine("Check Properly");
                }
            }
            Console.WriteLine("Values Updated Successfully!!");
            CloseConn();
        }
        //CLOSING THE CONNECTION
        public void CloseConn()
        {
            connect.Close();
        }
    }
}
