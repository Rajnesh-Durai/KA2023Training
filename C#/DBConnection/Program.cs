using DBConnection;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
class Program : ConfigurationSection
{
    public static void Main(String[] args)
    {
        //CONFIGURATION  ==> .NET CORE
        Console.WriteLine("--------");
        string s1 = ConfigurationManager.AppSettings["num1"];
        Console.WriteLine(s1);
        Console.WriteLine(ConfigurationManager.AppSettings["num2"]);



        /*
         
        DYNAMIC WAY OF CONNECTING DB FROM USER
         
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Enter the datasource= ");
        sb.Append(Console.ReadLine());
        Console.WriteLine(";database=");
        sb.Append(Console.ReadLine());
        Console.WriteLine(";integrated security=SSPI;");

        Console.WriteLine(sb);

        DBConnect DB = new DBConnect();
        DB.OpenConnec(sb.ToString());


        //DB.InsertTable();
        //DB.UpdateTable();
        DB.ReadTable();
        DB.CloseConnec();
        */
    }
}