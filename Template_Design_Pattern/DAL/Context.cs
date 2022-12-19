using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Template_Design_Pattern.DAL.Entities;

namespace Template_Design_Pattern.DAL
{
    public class Context:IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0A6CNA1;initial catalog=DbTemplateDesingPatten; integrated security=true");
        }
    }
}
