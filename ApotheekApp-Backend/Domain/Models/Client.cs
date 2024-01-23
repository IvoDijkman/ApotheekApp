using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Models
{
    public class Client : AppUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }



        public virtual List<Allergy> Allergies { get; set; }
        public virtual List<Medicine> Medicines { get; set; }
    }
}
