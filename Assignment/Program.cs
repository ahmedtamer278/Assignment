using Assignment.Context;
using Microsoft.Data.SqlClient;

namespace Assignment

{
    internal class Program
    {
        static void Main()
        {
            #region Data Access Technologies
            // ADO.Net => low level

            // connction string

            //string connectionstring = "server = . ; Database = ITI ; Trusted_Connection= True; Trust Server Certificate = True";

            //SqlConnection connection = new SqlConnection(connectionstring);//Un managed Resours
            //connection.Open();

            // Query

            //string Query = "select Dept_Name from Department";

            //SqlCommand command = new SqlCommand(Query,connection);

            //Reader
            //SqlDataReader reader = command.ExecuteReader();

            //reader.Read();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0]);
            //}

            // EF Core => object relational mapper [ORM]
            // L2E => Query Database Regardless Provider 
            // Generate Database Tables & Views from C# Classes Using Migrations => Code First
            // Generate C# Classes From Tables & Views In DB Using Command Or Wizard [Extension]=> DB Firts
            // SaveChange(); => Generate Sql Script Apply All Changes That Happend TO All Tracked Object By This Context
            // Dapper => Micro ORM
            #endregion
            #region EF Core & Classes
            //EF Core
            // Code First => Create DB , Table => Employees => Query


            //CompanyDbContext context = new CompanyDbContext();//Un Managed

            //try
            //{
            //    // Data Access Logic
            //}
            //finally
            //{ 
            //    //context.Dispose();
            //}
            //using (CompanyDbContext context = new CompanyDbContext()) // Must Be type Implements IDisposable
            //{ 

            //} 
            #endregion


            Console.ReadKey();
        }
    }
}
