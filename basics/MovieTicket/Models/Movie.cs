namespace MovieTicket.Models;

public class Movie
{
    public string title {get;set;}
    public int duration {get;set;}

    public Movie(string title, int duration)
    {
        this.title = title;
        this.duration = duration;
    }
    

}
