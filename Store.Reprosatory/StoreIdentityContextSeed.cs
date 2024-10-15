using Microsoft.AspNetCore.Identity;
using Store.Data.Entities.IdentityEntities;

namespace Store.Repository
{
    public class StoreIdentityContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Rana Mohamed",
                    Email = "rana.9237.gabr@gmail.com",
                    UserName = "RanaRere",
                    Address = new Address
                    {
                        FirstName = "Rana",
                        LastName = "Mohamed",
                        City = "Giza",
                        State = "Gize",
                        Street = "October",
                        PostalCode = "111111",
                    }
                };
                await userManager.CreateAsync(user, "Rana233");
            }
        }
    }
}