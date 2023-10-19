using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Data.Common;
using System.Data.SqlClient;

class Program
{
    public static string GetConnectString()
    {
        var configBuilder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory()) // file config in current directory
                   .AddJsonFile("appconfig.json");
        var configurationroot = configBuilder.Build();  // create configurationroot
        return configurationroot["db:connection1"];
        // Directory.GetCurrentDirectory() returns "C:\Users\admin\source\repos\Connection\SqlCommand\bin\Debug\net7.0"
    }
    static void Main(string[] args)
    {
        String sqlConnectString = GetConnectString();
        DbConnection connection = new SqlConnection(GetConnectString());
        // This is a bug
        /*connection.StatisticsEnabled = true;
        connection.FireInfoMessageEventOnUserErrors = true;*/

        connection.StateChange += (object sender, StateChangeEventArgs e) =>
        {
            Console.WriteLine($"Current state: {e.CurrentState}, Previous state: " + $"{e.OriginalState}");
        };

        connection.Open();
        // CRUD ...
        Console.WriteLine("CurrentDirectory: " + Directory.GetCurrentDirectory());
        connection.Close();


    }
}

