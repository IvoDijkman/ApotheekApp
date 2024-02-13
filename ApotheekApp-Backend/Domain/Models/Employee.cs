using Microsoft.AspNetCore.Identity;

namespace ApotheekApp.Domain.Models
{
    public class Employee : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}