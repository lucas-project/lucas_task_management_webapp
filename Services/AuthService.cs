using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using lucas_management_system.Models;

namespace lucas_management_system.Services
{
    public class AuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> RegisterAsync(string email, string password)
        {
            var user = new User { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);
            return result;
        }

        public async Task<SignInResult> LoginAsync(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);
            return result;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
