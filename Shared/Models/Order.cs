namespace LOLA.Shared;

public class Order
{
    public int Id {get; set;}
    public string Date {get; set;}
    public string Restaurant {get; set;}
    public string OrderName {get; set;}
    public string OrderText {get; set;}
    //public User User {get; set;} //this should be the foreign key
}