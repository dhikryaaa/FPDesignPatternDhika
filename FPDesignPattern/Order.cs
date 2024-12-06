using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPDesignPattern;

public class Order
{
    private string _userName;
    private string _userEmail;
    private string _productName;
    private int _buyQuantity;
    private ConnectionMediator _mediator;

    public string UserName { get => _userName; set => _userName = value; }
    public string UserEmail { get => _userEmail; set => _userEmail = value; }
    public string ProductName { get => _productName; set => _productName = value; }
    public int BuyQuantity
    {
        get { return _buyQuantity; }
        set
        {
            if (value < 1)
            {
                _buyQuantity = 1;
            }
            else 
            { 
                _buyQuantity = value;
            }
        }
    }
    public ConnectionMediator Mediator { get => _mediator; set => _mediator = value; }

    public Order(string userName, string userEmail, string productName, int buyQuantity, ConnectionMediator mediator)
    {
        UserName = userName;
        UserEmail = userEmail;
        ProductName = productName;
        BuyQuantity = buyQuantity;
        Mediator = mediator;
    }

    public void AddOrder()
    {
        Mediator.AddOrderToDatabase(UserName, UserEmail, ProductName, BuyQuantity);
    }
}