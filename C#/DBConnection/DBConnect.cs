using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DBConnection
{
    internal class DBConnect
    {
        SqlConnection conn;
        public void OpenConnec(string cnnstr)
        {
            conn = new SqlConnection(cnnstr);
            conn.Open();
            Console.WriteLine("Opened");
        }
        public void CreateTable()
        {
            
            SqlCommand cmd = new SqlCommand("create table stud_table1(rollno int, stud_name nvarchar(20))", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table Created");
            
        }
        public void InsertTable() 
        {
            SqlCommand cmd = new SqlCommand("insert into stud_table1 values(104,'Laxmeesh')", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Values Inserted");
        }
        public void UpdateTable() 
        {
            SqlCommand cmd = new SqlCommand("update stud_table1 set stud_name='Rajesh' where rollno=102", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Values Updated");
        }
        public void ReadTable() 
        {
            SqlCommand cmd = new SqlCommand("select * from stud_table1", conn);
            SqlDataReader sdr= cmd.ExecuteReader();
            if(sdr.HasRows)
            {
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["rollno"] + " " + sdr["stud_name"]);
                }
                Console.WriteLine("Table Readed");
            }
            else
            {
                Console.WriteLine("The Table is empty...");
            }
        }
        public void CloseConnec()
        {
            conn.Close();
        }
       
    }
}
