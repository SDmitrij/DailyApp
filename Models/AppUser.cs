using Microsoft.AspNetCore.Identity;

namespace DailyApp.Models
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
    }
}
