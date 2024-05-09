using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagament.API.Entities.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Stock).IsRequired();
        builder.Property(p => p.Price).IsRequired();

        builder.HasMany(p => p.ProductFeatures)
            .WithOne(pf => pf.Product)
            .HasForeignKey(pf => pf.ProductId);
    }
}