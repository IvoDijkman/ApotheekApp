using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class AppUser : IdentityUser
    {
        [Key]
        public override string Id { get => base.Id; set => base.Id = value; }
    }
}