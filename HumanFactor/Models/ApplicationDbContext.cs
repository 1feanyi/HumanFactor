using Microsoft.AspNet.Identity.EntityFramework;

namespace HumanFactor.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}