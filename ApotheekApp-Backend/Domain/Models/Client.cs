using System.ComponentModel.DataAnnotations;

namespace ApotheekApp.Domain.Models
{
    public class Client : AppUser
    {
        [Key]
        public override string Id { get => base.Id; set => base.Id = value; }

        public virtual ICollection<Allergy>? Allergies { get; set; }

        public string? AllergyId { get; set; }

        //public virtual string Address { get; set; }
        //public virtual string PostalCode { get; set; }
        //public virtual string City { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}