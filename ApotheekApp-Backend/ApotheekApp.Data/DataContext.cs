using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApotheekApp.Api;

namespace ApotheekApp.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
    }
}
