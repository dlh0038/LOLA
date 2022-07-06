using System;
using LOLA.Server.Data;
using LOLA.Shared;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private OrderContext _orderContext;

//constructor 
        public UserController(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

//##############################################################################################

//AUTHENTICATION METHODS

//##############################################################################################
//User login, used on client side in pages-login.razor when login button is hit
        
        [HttpPost("loginuser")] //parameter
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            System.Console.WriteLine("User has made it to controller");
            // checks if user is valid
            User loggedInUser = await _orderContext.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();

            if (loggedInUser != null)
            {
                //create a claim
                var claim = new Claim(ClaimTypes.Name, loggedInUser.Email);    

                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claim }, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //Sign In User
                await HttpContext.SignInAsync(claimsPrincipal);
            }
            else
            {
                return BadRequest();
            }
            return await Task.FromResult(loggedInUser);
        }
//##############################################################################################
//get user

        [HttpGet("getcurrentuser")] 
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            System.Console.WriteLine("inside get current user method ");
            User currentUser = new User();

            if (User.Identity.IsAuthenticated)
            {
                //gets logged in users email
                currentUser.Email = User.FindFirstValue(ClaimTypes.Name);
            }
            return await Task.FromResult(currentUser);
        }
//##############################################################################################
//Logout user

        [HttpGet("logoutuser")]
        public async Task<ActionResult<String>> LogOutUser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        } 
    }
}