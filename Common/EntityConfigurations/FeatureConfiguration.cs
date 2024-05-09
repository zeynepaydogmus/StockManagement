using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagament.API.Entities.EntityConfigurations;

public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Name).IsRequired().HasMaxLength(100);

        builder.HasMany(f => f.ProductFeatures)
            .WithOne(pf => pf.Feature)
            .HasForeignKey(pf => pf.FeatureId);
    }
}