using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolAppAuth.Data.Models;

namespace SchoolAppAuth.Data
{
        public class AppDbContext : IdentityDbContext<ApplicationUser>
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
            public DbSet<RefreshToken> RefreshTokens { get; set; }
        }
}
