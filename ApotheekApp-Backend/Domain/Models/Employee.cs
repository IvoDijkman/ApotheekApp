namespace ApotheekApp.Domain.Models
{
    public class Employee : AppUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}