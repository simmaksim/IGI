using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WEB_953506_SLIZH.Entities;

namespace WEB_953506_SLIZH.Data
{
    public class DbInitializer
    {
        public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();
            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                await roleManager.CreateAsync(roleAdmin);
            }
            if (!context.Users.Any())
            {
                var user = new ApplicationUser
                {
                    Email = "user@mail.ru",
                    UserName = "user@mail.ru"
                };
                await userManager.CreateAsync(user, "123456");
                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                await userManager.CreateAsync(admin, "123456");
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }
            ///!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
            if (!context.Disciplines.Any())
            {
                context.Disciplines.AddRange(
                    new List<Discipline>
                    {
                        new Discipline{DisciplineId=1, DisciplineName="Dota2"},
                        new Discipline{DisciplineId=2, DisciplineName="CS:GO"}
                    });
                await context.SaveChangesAsync();
            }
            if (!context.Players.Any())
            {
                context.Players.AddRange(
                    new List<Player>
                    {
                        new Player{NickName="S1mple", Team="Natus Vincere", Cost = 4450000, DisciplineId=2, Photo="Simple.jpg"},
                        new Player{NickName="Device", Team="Ninjas in pyjamas", Cost = 3200000, DisciplineId=2, Photo="device.jpg"},
                        new Player{NickName="Zywoo", Team="Vitality", Cost = 3750000, DisciplineId=2, Photo="Zywoo.jpg"},
                        new Player{NickName="Arteezy", Team="Evil Geniuses", Cost = 2000000, DisciplineId=1, Photo="Arteezy.jpg"},
                        new Player{NickName="Sumail", Team="OG", Cost = 5000000, DisciplineId=1, Photo="Sumail.jpg"},
                        new Player{NickName="Miracle", Team="Nigma", Cost = 2800000, DisciplineId=1, Photo="Miracle.jpg"},
                    });
                await context.SaveChangesAsync();
            }
        }
    }  
}