namespace OnlineShopping.Models;

public class Customers
{
    public string Name {get;set;}
    public string Email {get;set;}
    public string type {get;set;}

    public Customers (string name, string email, string type)
    {
        Name = name;
        Email = email;
        this.type = type;
        
    }


}
