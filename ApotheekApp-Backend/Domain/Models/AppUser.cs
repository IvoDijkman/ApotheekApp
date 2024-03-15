using ApotheekApp.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class AppUser : IEntity
    {
        [Key]
        public int Id { get; set; }

        public required virtual string FirstName { get; set; }
        public required virtual string LastName { get; set; }
    }
}