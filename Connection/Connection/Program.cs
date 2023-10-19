using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
class Progarm
{
    static void Main(string[] args)
    {
        /*// Using SqlConnectionStringBuilder
        DbConnectionStringBuilder DbStringBuilder = new SqlConnectionStringBuilder();
        DbStringBuilder["Data Source"] = @"DESTOP-VUONG\MAYAO";
        DbStringBuilder["Initial Catalog"] = "Bikestores";
        DbStringBuilder["Integrated Security"] = "True";
        // Keyword "using" helps connection close automatically at the end of the block "using"
        using (DbConnection connection = new SqlConnection(DbStringBuilder.ToString()))
        {
            connection.Open();
            // Query code
        }*/

        string SqlConnectStr = @"Data Source=DESTOP-VUONG\MAYAO;Initial Catalog=BikeStores;Integrated Security=True";
        var connection = new SqlConnection(SqlConnectStr);
        connection.Open();

        /*var command_1 = new SqlCommand();
        command_1.Connection = connection;
        command_1.CommandText = "SELECT CONCAT(first_name, ' ', last_name) AS full_name FROM sales.staffs WHERE staff_id = 5";
        command_1.Parameters.AddWithValue("staff_id", 5);
        // Using ExecuteScalar()
        var returnValue = command_1.ExecuteScalar();
        Console.WriteLine(returnValue);*/

        // Using ExceuteNonQuery()

        var command_2 = new SqlCommand();
        command_2.Connection = connection;
        command_2.CommandText = "INSERT INTO sales.staffs Values ('Le Xuan', 'Vuong', 'VuongLX2@fpt.com', '0977240300', 1, 1, NULL)";
        var result = command_2.ExecuteNonQuery();
        Console.WriteLine(result);

        connection.Close();
        
    }
}
