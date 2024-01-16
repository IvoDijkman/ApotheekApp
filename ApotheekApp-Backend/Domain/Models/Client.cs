using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Objects
{
    public class Client
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }



        public List<string> Allergies { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}
