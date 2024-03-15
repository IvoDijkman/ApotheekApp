using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models.Authentication
{
    public class RegisterModel
    {
        [Required]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        public required string PhoneNumber { get; set; }

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}