// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("Hello, World!");
//foreign key:
//[Foreign key("Column_Name in another table")]
//public     Order               Order{get,set}
//              |                    |
// Datatype of the class       Cls_Name or table name 



//NotMapping:
//Remove the connection by placing in above thetable or above the column name
//[NotMapped]

//[Stringlength]==>Applicable for only making the string length and it should be above the srting column
//[TimeStamp]==> For date and time