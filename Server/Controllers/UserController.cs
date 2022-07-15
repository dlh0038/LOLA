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
    public class UserController : ControllerBase
    {
        private DataContext _dataContext;
//constructor 
        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

//##############################################################################################
//AUTHENTICATION METHODS
//##############################################################################################
//User login, used on client side in pages-login.razor when login button is hit
        [HttpPost("loginuser")]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            System.Console.WriteLine("User has made it to controller");
            // checks if user is valid
            // u is data in database, user is user trying to login
            User loggedInUser = await _dataContext.Users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();

            if (loggedInUser != null)
            {
                System.Console.WriteLine("=======--------------------User Role = " + loggedInUser.Role);
                //create a claim, claimsIdentity, claimsPrincipal,
                //var claimID = new Claim(ClaimTypes.NameIdentifier, loggedInUser.Id.ToString());
                var claim = new Claim(ClaimTypes.Name, loggedInUser.Email);
                var claimRole = new Claim (ClaimTypes.Role, loggedInUser.Role == null ? "" : loggedInUser.Role); 
                var claimsIdentity = new ClaimsIdentity(new[] { claim , claimRole }, "serverAuth");
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                
                await HttpContext.SignInAsync(claimsPrincipal);
            }                                                  
            else
            {
                return BadRequest();
            }
            return await Task.FromResult(loggedInUser);
        }

        [HttpGet("getcurrentuser")] 
        public async Task<ActionResult<User>> GetCurrentUser()
        {
            User currentUser = new User();
            // user is refereneced from System.Security.Claims 
            if (User.Identity.IsAuthenticated)
            {
                //The claim value for the first claim with the specified type;
                //otherwise, null if the value doesn’t exist. 
                currentUser.Email = User.FindFirstValue(ClaimTypes.Name);
                currentUser.Role = User.FindFirstValue(ClaimTypes.Role);
            }                                                              
            return await Task.FromResult(currentUser);                     
        }

        [HttpGet("logoutuser")]
        public async Task<ActionResult<String>> LogOutUser()
        {
            await HttpContext.SignOutAsync();   //default scheme for signing out
            return "Success";
        } 

//##############################################################################################
// ADMIN METHODS for creating deleting and editing users
//##############################################################################################
        [HttpGet("getallusers")]
        public ActionResult<List<User>> GetAllUsers()
        {
            return _dataContext.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            return _dataContext.Users.FirstOrDefault(user => user.Id == id);
        }

// initiates an action on the server
        [HttpPost("postuser")]
        public ActionResult<User> PostUser(User user)
        {
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
            return user;
        }

// update an existing resource (user)
        [HttpPut("{id}")]
        public ActionResult<User> PutUser(int id, User user)
        {
            User newUser = _dataContext.Users.FirstOrDefault(user => user.Id == id);
            newUser.Name = user.Name;
            newUser.Email = user.Email;
            newUser.Password = user.Password;
            newUser.Role = user.Role;
            _dataContext.SaveChanges();
            return newUser;

        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            User oldUser = _dataContext.Users.FirstOrDefault(user => user.Id == id);
            _dataContext.Users.Remove(oldUser);
            _dataContext.SaveChanges();
        }
    }
}