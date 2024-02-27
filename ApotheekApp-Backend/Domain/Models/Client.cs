namespace ApotheekApp.Domain.Models
{
    public class Client : AppUser
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        //public virtual string Address { get; set; }
        //public virtual string PostalCode { get; set; }
        //public virtual string City { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual List<Allergy>? Allergies { get; set; }
        public virtual List<Medicine>? Medicines { get; set; }
    }
}