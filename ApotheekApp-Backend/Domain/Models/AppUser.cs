using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class AppUser : IdentityUser
    {
        [Key]
        public override string Id { get => base.Id; set => base.Id = value; }

        public required virtual string FirstName { get; set; }
        public required virtual string LastName { get; set; }
    }
}