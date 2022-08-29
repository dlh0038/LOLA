using System;
using LOLA.Server.Data;
using LOLA.Shared;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;



namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private DataContext _dataContext;
//constructor 
        public OrderController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    //Methods

     [HttpGet("getallorders")]
        public ActionResult<List<Restaurant>> GetAllRestaurants()
        {
            return _dataContext.Restaurants.ToList();
        }

     [HttpPost("postorder")]
        public ActionResult<Order> PostOrder(Order order)
        {
            _dataContext.Orders.Add(order);
            _dataContext.SaveChanges();
            Console.WriteLine("Saved Order to DB");
            return order;
        }


        [HttpPut("{orderid}")]


        
         [HttpDelete("{id}")]
        public void DeleteOrder(int id)
        {
            Order old = _dataContext.Orders.FirstOrDefault(order => order.Id == id);
            _dataContext.Orders.Remove(old);
            _dataContext.SaveChanges();
        }

    }
}