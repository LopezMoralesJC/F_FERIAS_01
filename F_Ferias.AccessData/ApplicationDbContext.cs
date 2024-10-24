
using F_Ferias.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F_Ferias.AccessData;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser , ApplicationRole , int> {
    public ApplicationDbContext(DbContextOptions options) : base(options) {
        
    }

      public DbSet<ApplicationUser> ApplicationUser { get; set; }

      // public DbSet<ApplicationRole> ApplicationRole { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
    }
}
