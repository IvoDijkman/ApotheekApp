namespace ApotheekApp.Domain.Dtos
{
    public class PrescriptionDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime IssueDate { get; set; }
        public bool IsCollected { get; set; }
        //TODO: Oliver: Is medicine nodig? of medicinedto?
        //public IEnumerable<Medicine> Medicines { get; set; } = Enumerable.Empty<Medicine>();
    }
}