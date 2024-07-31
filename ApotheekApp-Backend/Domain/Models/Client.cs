using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ApotheekApp.Domain.Models
{
    [ExcludeFromCodeCoverage]
    public class Client : AppUser
    {
        [Key]
        public override string Id { get => base.Id; set => base.Id = value; }

        public virtual ICollection<Allergy>? Allergies { get; set; }

        public string? AllergyId { get; set; }

        public virtual required string FirstName { get; set; }

        public virtual required string LastName { get; set; }

        //public virtual string Address { get; set; }
        //public virtual string PostalCode { get; set; }
        //public virtual string City { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}