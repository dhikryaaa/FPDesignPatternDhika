using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPDesignPattern;

public class User
{
    private string _name;
    private string _email;
    private ConnectionMediator _mediator;

    public string Name { get => _name; set => _name = value; }
    public string Email { get => _email; set => _email = value; }
    public ConnectionMediator Mediator { get => _mediator; set => _mediator = value; }

    public User(string name, string email, ConnectionMediator mediator)
    {
        Name = name;
        Email = email;
        Mediator = mediator;
    }

    public void AddUser()
    {
        Mediator.AddUserToDatabase(Name, Email);
    }
}
