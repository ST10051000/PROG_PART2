using Microsoft.AspNetCore.Identity;

namespace AgriEnergyConnectPlatform.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
