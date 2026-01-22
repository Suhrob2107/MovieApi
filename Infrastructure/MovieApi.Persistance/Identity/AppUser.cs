using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Persistance.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
