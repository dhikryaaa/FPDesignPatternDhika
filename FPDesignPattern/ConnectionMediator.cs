using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FPDesignPattern;

public class ConnectionMediator : IConnectionMediator
{
    private DatabaseConnection _databaseConnection;

    public DatabaseConnection DatabaseConnection { get => _databaseConnection; set => _databaseConnection = value; }

    public ConnectionMediator(DatabaseConnection databaseConnection)
    {
        DatabaseConnection = databaseConnection;
    }

    public void AddUserToDatabase(string name, string email)
    {
        DatabaseConnection.Query($"INSERT INTO users (name, email) VALUES ('{name}', '{email}')");
    }

    public void AddProductToDatabase(string productName, int quantity)
    {
        DatabaseConnection.Query($"INSERT INTO products (name, quantity) VALUES ('{productName}', {quantity})");
    }

    public void AddOrderToDatabase(string userName, string userEmail, string productName, int buyQuantity)
    {
        DatabaseConnection.Query($"INSERT INTO orders (userName, userEmail, productName, buyQuantity) VALUES ('{userName}', '{userEmail}', '{productName}', {buyQuantity})");
    }
}
