using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BoekenBeheren
{
    class Program
    {
        static SqlConnection GetConnection()
        {
            var connectionStringSetting = ConfigurationManager.ConnectionStrings["Boeken"];
            var connection = new SqlConnection(connectionStringSetting.ConnectionString);
            connection.StateChange += Connection_StateChange;
            return connection;
        }

        

        static void AddRecord(int keuze)
        {
            using (var connection = GetConnection())
            {
                 using (var command = connection.CreateCommand())
                {
                    if (keuze == 1)
                    {
                        Console.WriteLine("Geef naam van auteur in.");
                        string inputNaam = Console.ReadLine();

                        command.CommandText = "INSERT INTO [Auteur] ([Naam])" +
                            "VALUES (@naam)";
                        command.Parameters.AddWithValue("@naam", inputNaam);

                        connection.Open();
                        command.ExecuteNonQuery();

                        Console.WriteLine($"Auteur {inputNaam} is toegoevoegd.");
                    }
                    else if (keuze == 2)
                    {
                        Console.WriteLine("Geef naam van uitgeverij in.");
                        string inputNaam = Console.ReadLine();

                        command.CommandText = "INSERT INTO [Uitgeverij] ([Naam])" + 
                                              "VALUES (@naam)";
                        command.Parameters.AddWithValue("@naam", inputNaam);

                        connection.Open();
                        command.ExecuteNonQuery();

                        Console.WriteLine($"Uitgeverij {inputNaam} is toegoevoegd.");
                    }
                    else if (keuze == 3)
                    {
                        Console.WriteLine("Geef volgende in: ISBN nummer, Titel, Aantal paginas, Id van auteur, Id van uitgeverij");
                        string[] inputWaarden = Console.ReadLine().Split(',');

                        command.CommandText = "INSERT INTO [Boeken] ([ISBN], [Titel], [PaginaAantal], [AuteurId], [UitgeverijId])" +
                            "VALUES (@isbn, @titel, @paginas, @auteurid, @uitgeverijid)";
                        /*
                        var paramISBN = command.CreateParameter();
                        command.Parameters.Add(paramISBN);
                        paramISBN.ParameterName = "@isbn";
                        paramISBN.Value = inputWaarden[0].Trim();
                        paramISBN.SqlDbType = System.Data.SqlDbType.NVarChar;

                        var paramTitel = command.CreateParameter();
                        command.Parameters.Add(paramTitel);
                        paramTitel.ParameterName = "@titel";
                        paramTitel.Value = inputWaarden[1].Trim();
                        paramTitel.SqlDbType = System.Data.SqlDbType.NVarChar;

                        var paramPag = command.CreateParameter();
                        command.Parameters.Add(paramPag);
                        paramPag.ParameterName = "@paginas";
                        paramPag.Value = int.Parse(inputWaarden[2].Trim());
                        paramPag.SqlDbType = System.Data.SqlDbType.Int;

                        var paramAut = command.CreateParameter();
                        command.Parameters.Add(paramAut);
                        paramAut.ParameterName = "@auteurid";
                        paramAut.Value = int.Parse(inputWaarden[3].Trim());
                        paramAut.SqlDbType = System.Data.SqlDbType.Int;

                        var paramUitg = command.CreateParameter();
                        command.Parameters.Add(paramUitg);
                        paramUitg.ParameterName = "@uitgeverijid";
                        paramUitg.Value = int.Parse(inputWaarden[4].Trim());
                        paramUitg.SqlDbType = System.Data.SqlDbType.Int;
                        */
                        command.Parameters.AddWithValue("@isbn", inputWaarden[0].Trim());
                        command.Parameters.AddWithValue("@titel", inputWaarden[1].Trim());
                        command.Parameters.AddWithValue("@paginas", inputWaarden[2].Trim());
                        command.Parameters.AddWithValue("@auteurid", inputWaarden[3].Trim());
                        command.Parameters.AddWithValue("@uitgeverijid", inputWaarden[4].Trim());


                        connection.Open();
                        command.ExecuteNonQuery();

                        Console.WriteLine($"Boek {inputWaarden[0]}, {inputWaarden[1]} is toegoevoegd.");
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige keuze.");
                    }
                }
            }
        }

        static void GeefWeer(int keuze)
        {
            using (var connection = GetConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    if (keuze == 1)
                    {
                        command.CommandText = "SELECT [AuteurId], [Naam] from [Auteur]";

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["AuteurId"]}, {reader["Naam"]}");
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (keuze == 2)
                    {
                        command.CommandText = "SELECT [UitgeverijId], [Naam] from [Uitgeverij]";

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["UitgeverijId"]}, {reader["Naam"]}");
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (keuze == 3)
                    {
                        command.CommandText = "SELECT [Id], [ISBN], [Titel] from [Boeken]";

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["Id"]}, {reader["ISBN"]}, {reader["Titel"]}");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige keuze");
                    }
                }
            }
        }

        static void BoekDetails(string isbn)
        {
            using (var connection = GetConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT b.[ISBN], b.[Titel], b.[PaginaAantal], a.[Naam] as Auteur, u.[Naam] as Uitgever from [Boeken] b ";
                    command.CommandText += "INNER JOIN [Auteur] a on b.[AuteurId] = a.[AuteurId] ";
                    command.CommandText += "INNER JOIN [Uitgeverij] u on b.[UitgeverijId] = u.[UitgeverijId] ";
                    command.CommandText += "WHERE b.[ISBN] like @isbn";

                    //var paramIsbn = command.CreateParameter();
                    //command.Parameters.Add(paramIsbn);
                    //paramIsbn.ParameterName = "@isbn";
                    //paramIsbn.Value = isbn;
                    //paramIsbn.SqlDbType = System.Data.SqlDbType.NVarChar;
                    command.Parameters.AddWithValue("@isbn", isbn);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["ISBN"]}: {reader["Titel"]}, {reader["PaginaAantal"]} paginas, {reader["Auteur"] }, {reader["Uitgever"]}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

  
        static void Main(string[] args)
        {
            string keuze;
            do
            {
                Console.WriteLine("Wat wilt u doen?");
                Console.WriteLine("1) Records toevoegen.");
                Console.WriteLine("2) Tabel lezen.");
                Console.WriteLine("3) Details van boeken lezen.");
                Console.WriteLine("9) Exit.");
                Console.WriteLine();
                keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        Console.WriteLine("Wat wil u toevoegen?");
                        Console.WriteLine("1) Auteur");
                        Console.WriteLine("2) Uitgeverij");
                        Console.WriteLine("3) Boek");
                        Console.WriteLine();
                        string keuze2 = Console.ReadLine();
                        do
                        {
                            AddRecord(int.Parse(keuze2));
                            Console.WriteLine("Nog een record toevoegen? y/n");
                            keuze = Console.ReadLine();
                        } while (keuze != "n");
                        break;
                    case "2":
                        Console.WriteLine("Welke tabel wil u zien?");
                        Console.WriteLine("1) Auteur");
                        Console.WriteLine("2) Uitgeverij");
                        Console.WriteLine("3) Boek");
                        Console.WriteLine();
                        int keuze3 = int.Parse(Console.ReadLine());
                        GeefWeer(keuze3);
                        break;
                    case "3":
                        Console.WriteLine("Geef ISBN code van boek in.");
                        string isbn = Console.ReadLine();
                        BoekDetails(isbn);
                        break;
                    default:
                        break;
                }

            } while (keuze != "9");
            Console.ReadLine();
        }


        static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine($"--------------- Connection status: {e.CurrentState} -----------------");
        }
    }
}
