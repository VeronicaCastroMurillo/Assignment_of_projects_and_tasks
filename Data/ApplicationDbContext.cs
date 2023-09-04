using Assignment_of_projects_and_tasks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Assignment_of_projects_and_tasks.Data
{
    public class ApplicationDbContext : IdentityDbContext<Application_user, Application_role, string, IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Application_role>().HasData(new Application_role {Name= "Administrator", NormalizedName=  "ADMINISTRATOR", ConcurrencyStamp=null});
            builder.Entity<Application_role>().HasData(new Application_role {Name= "User", NormalizedName=  "USER", ConcurrencyStamp=null});
            builder.Entity<Application_role>().HasData(new Application_role {Name= "Manager", NormalizedName=  "MANAGER", ConcurrencyStamp=null});
            base.OnModelCreating(builder);
        }

    }
}