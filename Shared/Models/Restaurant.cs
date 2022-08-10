namespace LOLA.Shared;
using System.ComponentModel.DataAnnotations;

public class Restaurant
{
   
    public int Id { get; set; }

    public int Rating {get; set;}
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Link { get; set; }
    
}