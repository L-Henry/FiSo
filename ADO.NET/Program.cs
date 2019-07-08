using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NET
{
    class Program
    {

        static void Main(string[] args)
        {
            var connectionStringSetting = ConfigurationManager.ConnectionStrings["Northwind"];
            //var connection = new SqlConnection(connectionStringSetting.ConnectionString);

            using (var connection = new SqlConnection(connectionStringSetting.ConnectionString))
            {
                connection.StateChange += Connection_StateChange;
                connection.Open();
                Console.WriteLine();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO[dbo].[Categories] ([CategoryName],[Description])" +
                                             " VALUES (@naam, @description)";
                    //var paramterNaam = new SqlParameter();
                    //command.Parameters.Add(paramterNaam);

                    var parameterNaam = command.CreateParameter();
                    command.Parameters.Add(parameterNaam);
                    parameterNaam.ParameterName = "@naam";
                    parameterNaam.Value = "Bert";
                    parameterNaam.SqlDbType = System.Data.SqlDbType.NVarChar;

                    var parameterDesc = command.CreateParameter();
                    command.Parameters.Add(parameterDesc);
                    parameterDesc.ParameterName = "@description";
                    parameterDesc.Value = "Bibber";
                    parameterDesc.SqlDbType = System.Data.SqlDbType.NVarChar;

                    //command.ExecuteNonQuery();
                }


                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "Select [CategoryID], [CategoryName] FROM [Categories]";

                    command.CommandText += "where [CategoryName] like @categoryname";

                    var parameter = command.CreateParameter();
                    command.Parameters.Add(parameter);
                    parameter.ParameterName = "@categoryname";
                    parameter.Value = "Bert";
                    parameter.SqlDbType = System.Data.SqlDbType.NVarChar;

                    using (var rdr = command.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var categoryID = rdr["CategoryID"];
                            

                            Console.WriteLine($"ID: {rdr["categoryid"]}");
                            Console.WriteLine($"Naam: {rdr["categoryname"]}");
                            Console.WriteLine();
                        }
                    }
                }

                
            } 







            //connection.Close();

        


            Console.ReadLine();
        }

        private static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine("DB connection status: " + e.CurrentState);
        }
    }
}
