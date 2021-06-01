using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Memo { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}