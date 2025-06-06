using System.ComponentModel.DataAnnotations;
using static BestStoreMVC.Common.EntityValidationConstants;
namespace BestStoreMVC.ViewModel
{
    public class ResetPasswordViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = null!;

        [Required, MaxLength(PasswordMaxLenght)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "The Confirm Password field is required")]
        [Compare("Password", ErrorMessage = "ConfirmPassword and Password do not match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
