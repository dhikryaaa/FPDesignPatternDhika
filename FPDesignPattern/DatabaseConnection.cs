using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPDesignPattern;

public class DatabaseConnection
{
    private string _connectionString;
    private string _username;
    private string _password;

    public string ConnectionString { get => _connectionString; set => _connectionString = value; }
    public string Username { get => _username; set => _username = value; }
    public string Password { get => _password; set => _password = value; }

    public DatabaseConnection(string connectionString, string username, string password)
    {
        ConnectionString = connectionString;
        Username = username;
        Password = password;
    }

    public void Connect()
    {
        Console.WriteLine("Connecting to database...");
    }

    public void Query(string query)
    {
        Console.WriteLine("Executing query: " + query);
    }
}
