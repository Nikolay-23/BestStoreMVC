using BestStoreMVC.Models;
using BestStoreMVC.Services;
using BestStoreMVC.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BestStoreMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _singInManager;
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> singInManager)
        {
            _userManager = userManager;
            _singInManager = singInManager;
        }
        
        public IActionResult Register()
        {
            if(_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(registerViewModel);
            }

            //create a new account and authenticate the user
            var user = new ApplicationUser()
            {
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName,
                UserName = registerViewModel.Email, // UserName will be used to authenticate the user
                Email = registerViewModel.Email,
                PhoneNumber = registerViewModel.PhoneNumber,
                Address = registerViewModel.Address,
                CreatedAt = DateTime.Now
            };

            var result = await _userManager.CreateAsync(user, registerViewModel.Password);

            if (result.Succeeded)
            {
                //successful user registration
                await _userManager.AddToRoleAsync(user, "client");

                //sign in the new user
                await _singInManager.SignInAsync(user, false);

                return RedirectToAction("Index", "Home");
            }

            //registration failed => show registration errors
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(registerViewModel);
        }

        public async Task<IActionResult> Logout()
        {
            if(_singInManager.IsSignedIn(User))
            {
                await _singInManager.SignOutAsync();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            if(_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            var result = await _singInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RememberMe, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid login attempt.";
            }
                return View(loginViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var appUser = await _userManager.GetUserAsync(User);
            if (appUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var profileDto = new ProfileViewModel()
            {
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
                Email = appUser.Email ?? "",
                PhoneNumber = appUser.PhoneNumber,
                Address = appUser.Address
            };

            return View(profileDto);
        }

        public IActionResult AccessDenied()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
