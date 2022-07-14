using LOLA.Server.Data;
using LOLA.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private DataContext _dataContext; 
        public RestaurantController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("getallrestaurants")]
        public ActionResult<List<Restaurant>> GetAllRestaurants()
        {
            return _dataContext.Restaurants.ToList();
        }

        [HttpPost("postrestaurant")]
        public ActionResult<Restaurant> PostRestaurant(Restaurant restaurant)
        {
            _dataContext.Restaurants.Add(restaurant);
            _dataContext.SaveChanges();
            return restaurant;
        }
    }
}

