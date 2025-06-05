using System.ComponentModel.DataAnnotations;
using static BestStoreMVC.Common.EntityValidationConstants;

namespace BestStoreMVC.ViewModel
{
    public class ProfileViewModel
    {
        [Required(ErrorMessage = "The First Name field is required")]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "The Last Name field is required")]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required, EmailAddress]
        [MaxLength(EmailAddressMaxLength)]
        public string Email { get; set; } = null!;

        [Phone(ErrorMessage = "The format of the Phone Number is not valid")]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLenght)]
        public string Address { get; set; } = null!;
    }
}
