using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace First_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = DESKTOP-IKIAV0Q\SQLEXPRESS;
                                          Initial Catalog =  First Database;
                                            User ID = pc;
                                             Password=;
                                            Trusted_Connection = Yes;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            Debug.WriteLine("Connected to the Server!");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM dbo.People";
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    Debug.WriteLine(reader.GetString(1)+ "-" + reader.GetString(2));
                }
            }
            connection.Close();
        }
    }
}
