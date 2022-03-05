using Microsoft.AspNetCore.Identity;

namespace Core.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public bool Admin { get; set; }
        public bool Enabled { get; set; }
        public Address Address { get; set; }
    }
}