﻿using Microsoft.AspNetCore.Identity;

namespace BestStoreMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = ""; 
        public DateTime CreatedAt { get; set; }
    }
}
