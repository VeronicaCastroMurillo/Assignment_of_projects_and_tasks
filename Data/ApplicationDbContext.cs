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
            const string Admin_Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string Role_id = "ad376a8f-9eab-4bb9-9fca-30b01540f445";
            builder.Entity<Application_role>().HasData(new Application_role {Id = Role_id, Name= "Administrator", NormalizedName=  "ADMINISTRATOR", ConcurrencyStamp=null});
            builder.Entity<Application_role>().HasData(new Application_role {Name= "User", NormalizedName=  "USER", ConcurrencyStamp=null});
            builder.Entity<Application_role>().HasData(new Application_role {Name= "Manager", NormalizedName=  "MANAGER", ConcurrencyStamp=null});
            var hasher = new PasswordHasher<Application_user>(); 
            builder.Entity<Application_user>().HasData(new Application_user{Id= Admin_Id, id_number="1", name="Aaron", UserName="AaronAlfaro", NormalizedUserName="AARONALFARO", Email="aaronalfaro@gmail.com", NormalizedEmail="AARONALFARO@GMAIL.COM", EmailConfirmed=true, PasswordHash=hasher.HashPassword(null, "12345"), SecurityStamp=string.Empty}); 
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>{RoleId= Role_id, UserId=Admin_Id});
            base.OnModelCreating(builder);
        }

    }
}