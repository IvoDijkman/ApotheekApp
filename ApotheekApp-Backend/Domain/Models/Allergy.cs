using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class Allergy
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}