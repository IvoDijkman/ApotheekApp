using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Models.Authentication
{
    public static class UserRoles
    {
        public const string Admin = nameof(Admin);
        public const string Employee = nameof(Employee);
        public const string Client = nameof(Client);
    }
}
