using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PrisonDatabase.Infrastructure;

public class PrisonDatabaseDbContext : IdentityDbContext<IdentityUser>
{
    public PrisonDatabaseDbContext(DbContextOptions<PrisonDatabaseDbContext> options)
        : base(options) { }
}
