using BaumarktSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Baumarkt_E_commerce_Platform.Data
{
    public class BaumarktSystemDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public BaumarktSystemDbContext(DbContextOptions<BaumarktSystemDbContext> options)
            : base(options)
        {
        }
    }
}