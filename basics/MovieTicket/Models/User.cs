using System.Diagnostics.Contracts;

namespace MovieTicket.Models;

public class User
{
    public string name{get;set;}
    public string email{get;set;}

    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
    }

}