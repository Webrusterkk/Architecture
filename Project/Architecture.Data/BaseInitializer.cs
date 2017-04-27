using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Architecture.Core.Entities;

using System.Data.Entity;
namespace Architecture.Data
{
 

    public class BaseInitializer : DropCreateDatabaseIfModelChanges<ArchitectureDbContext>
    {
        protected override void Seed(ArchitectureDbContext context)
        {
            Initialize(context);
            base.Seed(context);
        }

        public void Initialize(ArchitectureDbContext context)
        {
            try
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
                {
                    AllowOnlyAlphanumericUserNames = false
                };
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!roleManager.RoleExists("Admin"))
                {
                    roleManager.Create(new IdentityRole("Admin"));
                }

                if (!roleManager.RoleExists("Member"))
                {
                    roleManager.Create(new IdentityRole("Member"));
                }

                var user = new ApplicationUser()
                {
                    Email = "Kishore@gmail.com",
                    UserName = "test@test.com",
                    FirstName = "Krishna",
                    LastName = "Kishore"
                };

                var userResult = userManager.Create(user, "Newmek@123");

                if (userResult.Succeeded)
                {
                    userManager.AddToRole<ApplicationUser, string>(user.Id, "kishore");
                }

                context.Commit();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
