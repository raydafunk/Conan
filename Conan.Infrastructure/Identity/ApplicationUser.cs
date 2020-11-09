using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conan.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser
    {
        // Extended  Properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
