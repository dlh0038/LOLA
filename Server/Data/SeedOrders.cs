using System;
using System.Collections.Generic;
using System.Linq;
using LOLA.Shared;

namespace LOLA.Server.Data
{
    public static class DbInit
    {
        public static void Init(OrderContext context)
        {
            if(context.Orders.Any()) return; // DB has been seeded
            var orders = new Order[]
            {
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Chris",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Denny",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Emilio",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Garren",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Greg",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Hani",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Kari",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Kris",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Nicole",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Tammy",
                OrderText = ""
            },
            new Order{
                Date = "25-May",
                Restaurant = "Primanti's",
                OrderName = "Tommi",
                OrderText = ""
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Chris",
                OrderText = "hibachi chicken lunch w/ salad and fried rice"
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Denny",
                OrderText = "California and Boston Sushi Rolls"
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Emilio",
                OrderText = "hibachi chicken lunch w/ salad and fried rice"
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Garren",
                OrderText = "hibachi shrimp with fried rice and salad, upgrade to bento box with 2 spring roll and 4 California roll"
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Greg",
                OrderText = ""
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Hani",
                OrderText = "hibachi chicken lunch w/ salad and fried rice"
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Kari",
                OrderText = ""
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Kris",
                OrderText = "hibachi chicken lunch with lo-mein noodles and miso soup"
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Nicole",
                OrderText = ""
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Tammy",
                OrderText = ""
            },
            new Order{
                Date = "1-Jun",
                Restaurant = "Kumo Japan",
                OrderName = "Tommi",
                OrderText = ""
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Chris",
                OrderText = "Gyro w/ spicy meat, fries and diet Coke"
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Denny",
                OrderText = "Gyro w/ mild meat"
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Emilio",
                OrderText = "Gyro w/ mild meat, fries and Sprite"
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Garren",
                OrderText = "Filet Mignon Steak kabob sandwich"
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Greg",
                OrderText = ""
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Hani",
                OrderText = "Gyro w/ mild meat, fries and Diet Coke"
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Kari",
                OrderText = ""
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Kris",
                OrderText = ""
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Nicole",
                OrderText = "Chicken Tender Kabob"
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Tammy",
                OrderText = ""
            },
            new Order{
                Date = "8-Jun",
                Restaurant = "Ali's",
                OrderName = "Tommi",
                OrderText = ""
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Chris",
                OrderText = ""
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Denny",
                OrderText = "10 Boneless mild wings with ranch, french fries, carrots and celery"
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Emilio",
                OrderText = ""
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Garren",
                OrderText = "10 Boneless honey bbq wings with ranch, french fries, carrots and celery"
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Greg",
                OrderText = ""
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Hani",
                OrderText = ""
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Kari",
                OrderText = "6 Boneless asian zing wings with ranch"
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Kris",
                OrderText = "10 Boneless honey bbq wings with ranch, french fries, carrots and celery"
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Nicole",
                OrderText = "6 boneless parmasean garlic wings with ranch, mac & cheese"
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Tammy",
                OrderText = "10 Boneless asian zing wings with blue cheese, french fries, carrots and celery"
            },
            new Order{
                Date = "15-Jun",
                Restaurant = "Buffalo Wild Wings",
                OrderName = "Tommi",
                OrderText = ""
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Chris",
                OrderText = ""
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Denny",
                OrderText = "Bangers and Mash"
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Emilio",
                OrderText = "Devils Cut BFG Wings"
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Garren",
                OrderText = "12 boness sweet BBQ wings with ranch"
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Greg",
                OrderText = ""
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Hani",
                OrderText = "12 boness sweet BBQ wings with ranch"
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Kari",
                OrderText = ""
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Kris",
                OrderText = "Chicken Breast Dinner"
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Nicole",
                OrderText = "Celtic Knot, Chicken Taco"
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Tammy",
                OrderText = "Mac N Cheese"
            },
            new Order{
                Date = "22-Jun",
                Restaurant = "Meagher's Irish Pub",
                OrderName = "Tommi",
                OrderText = ""
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Chris",
                OrderText = ""
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Denny",
                OrderText = "Tacos de Carne Asada"
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Emilio",
                OrderText = "Arroz con Pollo"
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Garren",
                OrderText = "Special Lunch #16"
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Greg",
                OrderText = ""
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Hani",
                OrderText = "Lunch Fajitas"
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Kari",
                OrderText = ""
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Kris",
                OrderText = "Arroz con Pollo & Vegetables"
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Nicole",
                OrderText = ""
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Tammy",
                OrderText = "Arroz con Pollo"
            },
            new Order{
                Date = "29-Jun",
                Restaurant = "Don Patron",
                OrderName = "Tommi",
                OrderText = ""
            }
        };
          context.Orders.AddRange(orders);
          context.SaveChanges();  
        }
    }
}
