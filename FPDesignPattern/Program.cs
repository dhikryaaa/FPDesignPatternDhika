namespace FPDesignPattern;

internal class Program
{
    static void Main(string[] args)
    {
        DatabaseConnection db = new DatabaseConnection("jdbc:mysql://localhost:3306/mydatabase", "admin", "rahasia");
        db.Connect();

        Console.WriteLine();

        ConnectionMediator mediator = new ConnectionMediator(db);

        //Declare User
        User user1 = new User("Andhika", "Andhika@gmail.com", mediator);
        User user2 = new User("Fadhli", "Fadhli@gmail.com", mediator);
        User user3 = new User("Ibnu", "Ibnu@gmail.com", mediator);

        //Add User to Database
        user1.AddUser();
        user2.AddUser();
        user3.AddUser();

        Console.WriteLine();

        //Declare Product
        Product product1 = new Product("Ice Cream", 10, mediator);
        Product product2 = new Product("Biscuit", 50, mediator);
        Product product3 = new Product("Soft Drink", 40, mediator);

        //Add Product to Database
        product1.AddProdut();
        product2.AddProdut();
        product3.AddProdut();

        Console.WriteLine();

        //Declare Order
        Order order1 = new Order("Andhika", "Andhika@gmail.com", "Ice Cream", 2, mediator);
        Order order2 = new Order("Ibnu", "Ibnu@gmail.com", "Soft Drink", 1, mediator);

        //Add Order to Database
        order1.AddOrder();
        order2.AddOrder();

        Console.WriteLine();
    }
}