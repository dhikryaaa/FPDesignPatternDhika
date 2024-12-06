using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPDesignPattern;

public interface IConnectionMediator
{
    public void AddUserToDatabase(string name, string email);
    public void AddProductToDatabase(string productName, int quantity);
    public void AddOrderToDatabase(string userName, string userEmail, string productName, int buyQuantity);
}
