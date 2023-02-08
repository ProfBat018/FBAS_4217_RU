using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

#region Напоминание 

//using SqlCommand command = new();

/*
    Напоминаю:
    using в данном контексте используется как 
      SqlConnection conn = new SqlConnection();
        try
        {
        }
        finally
        {
            if (conn != null)
            {
                ((IDisposable)conn).Dispose();
            }
        }
 */
#endregion


#region КакХранитьConnString

// fhdgfhdrgfhfhdgfhdrgfhfhdgfhdrgfh

#endregion

#region FirstQuery

/*
Как ADO.NET должен понять с какой базой данных ему работать ? 
*/


ConfigurationBuilder builder = new();
builder.AddJsonFile("appsettings.json");

var res = builder.Build();

using SqlConnection conn = new(res.GetConnectionString("Academy"));
conn.Open();
if (conn.State == System.Data.ConnectionState.Open)
{

}
using SqlCommand command = new("select * from Teachers", conn);

SqlDataReader reader = command.ExecuteReader();

foreach (var item in reader.GetColumnSchema())
{
    Console.Write(item.ColumnName + '\t');
}
Console.WriteLine();

while (reader.Read())
{
    Console.WriteLine($"{reader[0]}\t {reader[1]}\t{reader[2]}");
}


#endregion


