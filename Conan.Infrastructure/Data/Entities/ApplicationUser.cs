using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conan.Infrastructure.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Extended  Properties
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
