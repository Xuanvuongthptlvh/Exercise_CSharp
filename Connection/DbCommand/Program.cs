using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

class Progarm
{
    static void Main(string[] args)
    {
        string SqlConnectStr = @"Data Source=DESTOP-VUONG\MAYAO;Initial Catalog=BikeStores;Integrated Security=True";
        DbConnection connection = new SqlConnection(SqlConnectStr);
        connection.Open();
        using DbCommand command = new SqlCommand();
        command.Connection = connection;
        command.CommandText = "SELECT * FROM sales.staffs";
        // Using ExecuteReader()
        var datareader = command.ExecuteReader();
        if (datareader.HasRows)
        {
            while (datareader.Read())
            {
                Console.WriteLine($"Full_name: {datareader["first_name"]} {datareader["last_name"]}");
            }
        }
        else
        {
            Console.WriteLine("No data");
        }
        connection.Close();
    }
}
