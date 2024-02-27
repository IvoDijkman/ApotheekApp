namespace ApotheekApp.Domain.Models
{
    public class Employee : AppUser
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}