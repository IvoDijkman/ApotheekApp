namespace ApotheekApp.Domain.Models
{
    public class Client : AppUser
    {
        public virtual ICollection<Allergy> Allergies { get; set; } = [];

        public virtual ICollection<Prescription> Prescriptions { get; set; } = [];

        //public virtual string Address { get; set; }
        //public virtual string PostalCode { get; set; }
        //public virtual string City { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}