﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Models
{
    public class Employee : AppUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
