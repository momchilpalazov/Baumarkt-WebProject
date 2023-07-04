using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Baumarkt_E_commerce_Platform.Data
{
    public class BaumarktSystemDbContext : IdentityDbContext
    {
        public BaumarktSystemDbContext(DbContextOptions<BaumarktSystemDbContext> options)
            : base(options)
        {
        }
    }
}