using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Models
{
    public class ApplicationUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }

    }
}
