namespace ApotheekApp.Domain.Models
{
    public class Client : AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual List<Allergy> Allergies { get; set; }
        public virtual List<Medicine> Medicines { get; set; }
    }
}