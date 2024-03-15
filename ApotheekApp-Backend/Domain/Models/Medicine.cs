using ApotheekApp.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class Medicine : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Manual { get; set; }
        public string? Type { get; set; }
        public int? Stock { get; set; }
    }
}