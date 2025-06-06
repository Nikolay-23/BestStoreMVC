using System.ComponentModel.DataAnnotations;
using static BestStoreMVC.Common.EntityValidationConstants;

namespace BestStoreMVC.ViewModel
{
    public class PasswordViewModel
    {
        [Required(ErrorMessage = "The Curren Password field is required"), MaxLength(PasswordMaxLenght)]
        public string CurrentPassword { get; set; } = null!;
        [Required(ErrorMessage = "The New Password field is required"), MaxLength(PasswordMaxLenght)]
        public string NewPassword { get; set; } = null!;

        [Required(ErrorMessage = "The Confirm Password field is required")]
        [Compare("NewPassword", ErrorMessage = "Confirm Password and Password do not match")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
