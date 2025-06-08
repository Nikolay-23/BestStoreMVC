using System.ComponentModel.DataAnnotations;
using static BestStoreMVC.Common.EntityValidationConstants;
namespace BestStoreMVC.ViewModel
{
    public class CheckOutViewModel
    {
        [Required(ErrorMessage = "The Delivery Address is required.")]
        [MaxLength(DeliveryAddressMaxLenght)]
        public string DeliveryAddress { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
    }
}
