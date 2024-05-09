using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockManagament.API.Entities;
using StockManagament.API.Entities.EntityConfigurations;

namespace StockManagament.API.DbContexts;

public class AppDbContext : IdentityDbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<ProductFeatureAssoc> ProductFeatureAssoc { get; set; }
    public DbSet<AdminUser> AdminUsers { get; set; }
    public DbSet<Borrow> Borrows { get; set; }
    public DbSet<BorrowUserAssoc>   BorrowUserAssocs { get; set; }
    private readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Configuration.GetConnectionString("postgre"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new FeatureConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductFeatureAssocConfiguration());
    }

}