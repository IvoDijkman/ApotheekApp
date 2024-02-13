using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Models.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "E-mail is required")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }
    }
}
