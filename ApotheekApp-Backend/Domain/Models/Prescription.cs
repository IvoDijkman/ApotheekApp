using ApotheekApp.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public record Prescription : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Medicine> Medicines { get; set; } = [];
    }
}