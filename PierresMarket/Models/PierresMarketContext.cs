using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PierresMarket.Models 
{
  public class PierresMarketContext : IdentityDbContext <ApplicationUser>
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }
    public PierresMarketContext(DbContextOptions options) : base(options) { }
  }
}
