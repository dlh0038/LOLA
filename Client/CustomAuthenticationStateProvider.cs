using System.Net.Http.Json;
using System.Security.Claims;
using LOLA.Shared;
using Microsoft.AspNetCore.Components.Authorization;

namespace LOLA.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        public CustomAuthenticationStateProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // In this method I am creating 

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
           Console.WriteLine("GetAuthenticationStateAsync Made it to this method");
           #nullable enable
            User? currentUser = await _httpClient.GetFromJsonAsync<User>("user/getcurrentuser");
            if (currentUser != null && currentUser.Email != null)
            { 
                System.Console.WriteLine("User Role = " + currentUser.Role);
                //create a claim
                var claim = new Claim (ClaimTypes.Name, currentUser.Email);
                var claimRole = new Claim (ClaimTypes.Role, currentUser.Role == null ? "" : currentUser.Role);
                //create a claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] {claim, claimRole}, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                
                Console.WriteLine("current user claim");
                return new AuthenticationState(claimsPrincipal);
            }
            else
                Console.WriteLine("User new claim");
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())); 
        }
    }
} 