namespace LOLA.Shared;

public class Order
{
    public int Id {get; set;}
    public string OrderText {get; set;}
    public double OrderTotal {get; set;}
    //public User User {get; set;} //this should be the foreign key
}