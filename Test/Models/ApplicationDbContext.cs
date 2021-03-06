using Microsoft.AspNet.Identity.EntityFramework;

namespace Test.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public 
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}