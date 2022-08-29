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
    public class RestaurantController : ControllerBase
    {
        private DataContext _dataContext;
//constructor 
        public RestaurantController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    //Methods

     [HttpGet("getallrestaurants")]
        public ActionResult<List<Restaurant>> GetAllRestaurants()
        {
            return _dataContext.Restaurants.ToList();
        }

     [HttpPost("postrestaurant")]
        public ActionResult<Restaurant> PostRestaurant(Restaurant rest)
        {
            _dataContext.Restaurants.Add(rest);
            _dataContext.SaveChanges();
            return rest;
        }


        [HttpPut("{restid}")]


         public ActionResult<Restaurant> PutRestaurant(int id, Restaurant rest)
        {
            Restaurant newRest = _dataContext.Restaurants.FirstOrDefault(rest => rest.Id == id);
            newRest.Name = rest.Name;
            newRest.PhoneNumber = rest.PhoneNumber;
            newRest.Link = rest.Link;
            _dataContext.SaveChanges();
            return newRest;
        }
         [HttpDelete("{id}")]
        public void DeleteRestaurant(int id)
        {
            Restaurant old = _dataContext.Restaurants.FirstOrDefault(rest => rest.Id == id);
            _dataContext.Restaurants.Remove(old);
            _dataContext.SaveChanges();
        }

    }
    }