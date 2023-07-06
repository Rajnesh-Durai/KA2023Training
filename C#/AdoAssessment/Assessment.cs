using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoAssessment
{
    internal class Assessment
    {
        SqlConnection connec;
        public void OpenConnec(string str)
        {
            connec = new SqlConnection(str);
            try
            {
                connec.Open();
                Console.WriteLine("Opened");
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Connected");
                Console.WriteLine(ex.Message);
            }
            
        }
        public void CreateTable() 
        {
            SqlCommand table1 = new SqlCommand("create table Regions(Region_id INT PRIMARY KEY, Region nvarchar(20));", connec);
            SqlCommand table3 = new SqlCommand("create table Cust_transaction(Customer_id INT PRIMARY KEY, Deposit DECIMAL(10,2), Balance DECIMAL(10,2), Date_Trans DATE);", connec);
            SqlCommand table2 = new SqlCommand("create table Customer_Nodes(node_id INT PRIMARY KEY,Region_id INT FOREIGN KEY REFERENCES Regions(Region_id),Customer_id INT FOREIGN KEY REFERENCES Cust_transaction(Customer_id));", connec);
            try
            {
                table1.ExecuteNonQuery();
                table3.ExecuteNonQuery();
                table2.ExecuteNonQuery();
                Console.WriteLine("created");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("NOT CREATED");
                Console.WriteLine(ex.Message);
            }
        }
        public void InsertValue()
        {
            SqlCommand insert = new SqlCommand("insert into Regions values (1,'Chennai'),(2,'Madurai'),(3,'Tirunelveli'),(4,'Chennai')", connec);
            SqlCommand insert3 = new SqlCommand("insert into Cust_transaction values (101,4500.21,50000.50,'2023/05/16'),(102,5600.21,55000.50,'2023/05/26'),(103,3000.06,45000.50,'2023/06/16'),(104,5000.21,60000.50,'2023/04/16')", connec);
            SqlCommand insert2 = new SqlCommand("insert into Customer_Nodes values (3,1,101),(2,2,102),(6,3,103),(4,4,104)", connec);
            try
            {
                insert.ExecuteNonQuery();
                insert3.ExecuteNonQuery();
                insert2.ExecuteNonQuery();
                Console.WriteLine("inserted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("NOT INSERTED");
                Console.WriteLine(ex.Message);
            }
        }
        public void Qn1()
        {
            SqlCommand sql1 = new SqlCommand("select COUNT(c.node_id) AS NO_OF_NODES, r.Region from Customer_Nodes c inner join Regions r ON r.Region_id=c.Region_id group by r.Region", connec);

            try
            {
                sql1.ExecuteNonQuery();
                Console.WriteLine("done");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Done");
            }
            //Read the values 
            SqlDataReader sqlDataReader = sql1.ExecuteReader();
            if(sqlDataReader.HasRows ) 
            {
                while(sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["NO_OF_NODES"] + ":" + sqlDataReader["Region"]);
                }
            }
            else
            {
                Console.WriteLine("Not Executed");
            }

        }
        public void Qn2()
        {
            SqlCommand sql1 = new SqlCommand("select COUNT(c.Customer_id) AS No_Of_Customer, r.Region from Customer_Nodes c inner join Regions r ON r.Region_id=c.Region_id group by r.Region", connec);

            try
            {
                sql1.ExecuteNonQuery();
                Console.WriteLine("Connection done");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Done");
            }
            //Read the values 
            SqlDataReader sqlDataReader = sql1.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["No_Of_Customer"] + ":" + sqlDataReader["Region"]);
                }
            }
            else
            {
                Console.WriteLine("Not Executed");
            }
        }
        public void Qn3()
        {
            SqlCommand sql1 = new SqlCommand("select COUNT(Customer_id) AS TOTAL_COUNT, AVG(Deposit)AS AVG_DEPOSIT from Cust_transaction", connec);
            try
            {
                sql1.ExecuteNonQuery();
                Console.WriteLine("Connection done");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Done");
            }
            //Read the values 
            SqlDataReader sqlDataReader = sql1.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine("Total count: "+sqlDataReader["TOTAL_COUNT"]);
                    Console.WriteLine("Avg Deposit: " + sqlDataReader["AVG_DEPOSIT"]);

                }
            }
            else
            {
                Console.WriteLine("Not Executed");
            }
        }
        public void Qn4()
        {
            SqlCommand sql1 = new SqlCommand("select Customer_id, Deposit+Balance AS TOTAL_BALANCE from Cust_transaction  order by Date_Trans", connec);
            try
            {
                sql1.ExecuteNonQuery();
                Console.WriteLine("Connection done");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Done");
            }
            //Read the values 
            SqlDataReader sqlDataReader = sql1.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["Customer_id"] + ":" + sqlDataReader["TOTAL_BALANCE"]);

                }
            }
            else
            {
                Console.WriteLine("Not Executed");
            }
        }
        public void Qn5()
        {
            SqlCommand sql1 = new SqlCommand("select COUNT(Customer_id) AS TOTAL_COUNT from Cust_transaction where Deposit>0", connec);
            try
            {
                sql1.ExecuteNonQuery();
                Console.WriteLine("Connection done");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Not Done");
            }
            //Read the values 
            SqlDataReader sqlDataReader = sql1.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["TOTAL_COUNT"] + " has increased");

                }
            }
            else
            {
                Console.WriteLine("Not Executed");
            }
        }
        public void Close()
        {
            connec.Close();
        }
    }
}
