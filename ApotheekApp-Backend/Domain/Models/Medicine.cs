namespace ApotheekApp.Domain.Models
{
    public class Medicine
    {
        public virtual ICollection<ClientMedicine> Clients { get; set; }
        public IEnumerable<ClientMedicine> ClientLink { get; set; }
        public int MedicineId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Manual { get; set; }
        public string Type { get; set; }

        public int Stock { get; set; }
    }
}