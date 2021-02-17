using DailyApp.Models;

namespace DailyApp.Security.Interfaces
{
    public interface IJwtGenerator
    {
        string CreateToken(AppUser user);
    }
}
