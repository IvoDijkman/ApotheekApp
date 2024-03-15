namespace ApotheekApp.Domain.Models
{
    public class Employee : AppUser
    {
        public virtual required string FirstName { get; set; }

        public virtual required string LastName { get; set; }
    }
}