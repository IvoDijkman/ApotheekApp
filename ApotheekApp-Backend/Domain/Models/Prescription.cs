using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }

        public required int ClientId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime IssueDate { get; } = DateTime.UtcNow;
        public bool IsCollected { get; set; } = false;
        public IEnumerable<Medicine> Medicines { get; set; } = Enumerable.Empty<Medicine>();
    }
}