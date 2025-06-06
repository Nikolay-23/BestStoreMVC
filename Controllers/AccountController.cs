using BestStoreMVC.Models;
using BestStoreMVC.Services;
using BestStoreMVC.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BestStoreMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _singInManager;
        private readonly IConfiguration _configuration;
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> singInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _singInManager = singInManager;
            _configuration = configuration;
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

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Profile(ProfileViewModel profileViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMessage = "Please fill all the required fields with valid values";
                return View(profileViewModel);
            }

            //Get the current user
            var appUser = await _userManager.GetUserAsync(User);
            if (appUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //Update the user profile
            appUser.FirstName = profileViewModel.FirstName;
            appUser.LastName = profileViewModel.LastName;
            appUser.UserName = profileViewModel.Email;
            appUser.Email = profileViewModel.Email;
            appUser.PhoneNumber = profileViewModel.PhoneNumber;
            appUser.Address = profileViewModel.Address;

            var result = await _userManager.UpdateAsync(appUser);

            if (result.Succeeded)
            {
                ViewBag.SuccessMessage = "Profile updated successfully";
            }
            else
            {
                ViewBag.ErrorMessage = "Unable to update the profile: " + result.Errors.First().Description; 
            }

            return View(profileViewModel);
        }

        [Authorize]
        public IActionResult Password()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Password(PasswordViewModel passwordViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            //Get the current user
            var appUser = await _userManager.GetUserAsync(User);
            if (appUser == null)
            {
                return RedirectToAction("Index", "Home"); 
            }

            //update the password
            var result = await _userManager.ChangePasswordAsync(appUser, passwordViewModel.CurrentPassword, passwordViewModel.NewPassword);

            if (result.Succeeded)
            {
                ViewBag.SuccessMessage = "Password update successfully";
            }
            else
            {
                 ViewBag.ErrorMessage = "Error: " + result.Errors.First().Description;
            }
            return View();
        }
        public IActionResult AccessDenied()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ForgotPassword()
        {
            if(_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword([Required, EmailAddress] string email)
        {
            if (_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Email = email;

            if (!ModelState.IsValid)
            {
                ViewBag.EmailError = ModelState["email"]?.Errors.First().ErrorMessage ?? "Invalid Email Address";
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                // generate password reset token
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                string resetUrl = Url.ActionLink("ResetPassword", "Account", new { token }) ?? "URL Error";

                // send url by email
                string senderName = _configuration["BrevoSettings:SenderName"] ?? "";
                string senderEmail = _configuration["BrevoSettings:SenderEmail"] ?? "";
                string username = user.FirstName + " " + user.LastName;
                string subject = "Password Reset";
                string message = "Dear " + username + ",\n\n" +
                                 "You can reset your password using the following link:\n\n" +
                                 resetUrl + "\n\n" +
                                 "Best Regards";

                EmailSender.SendEmail(senderName, senderEmail, username, email, subject, message);
            }

            ViewBag.SuccessMessage = "Please check your Email account and click on the Password Reset link!";

            return View();
        }

        public IActionResult ResetPassword(string? token)
        {
            if(_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            if(token == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(string? token, ResetPasswordViewModel model)
        {
            if (_singInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            if (token == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user == null)
            {
                ViewBag.ErrorMessage = "Token not valid";
                return View(model);
            }

            var result = await _userManager.ResetPasswordAsync(user, token, model.Password);

            if(result.Succeeded)
            {
                ViewBag.SuccessMessage = "Password reset successfully!";
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }
    }
}
