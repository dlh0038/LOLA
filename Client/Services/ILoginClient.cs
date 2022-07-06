using LOLA.Shared;

namespace LOLA.Client.Services
{
    public interface ILoginClient
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Task<User> LoginUser();
    }
}