using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPDesignPattern;

public class Product
{
    private string _productName;
    private int _quantity;
    private ConnectionMediator _mediator;

    public string ProductName { get => _productName; set => _productName = value; }
    public int Quantity
    { 
        get {  return _quantity; }
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            else
            {
                _quantity = value;
            }
        }
    }
    public ConnectionMediator Mediator { get => _mediator; set => _mediator = value; }

    public Product(string productName, int quantity, ConnectionMediator mediator)
    {
        ProductName = productName;
        Quantity = quantity;
        Mediator = mediator;
    }

    public void AddProdut()
    {
        Mediator.AddProductToDatabase(ProductName, Quantity);
    }
}
