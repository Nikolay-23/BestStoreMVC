using Microsoft.AspNetCore.Identity;

namespace BestStoreMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Orders = new HashSet<Order>();
        }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = ""; 
        public DateTime CreatedAt { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
