using lucas_management_system.Services;
using Microsoft.AspNetCore.Mvc;
using lucas_management_system.Services;

namespace lucas_management_system.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Authenticate user and sign in
                // Redirect to dashboard
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Register new user and sign in
                // Redirect to dashboard
            }

            return View(model);
        }
    }
}

