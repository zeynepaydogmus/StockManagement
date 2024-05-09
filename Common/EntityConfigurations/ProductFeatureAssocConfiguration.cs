using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StockManagament.API.Entities.EntityConfigurations;

public class ProductFeatureAssocConfiguration : IEntityTypeConfiguration<ProductFeatureAssoc>
{
    public void Configure(EntityTypeBuilder<ProductFeatureAssoc> builder)
    {
        builder.HasKey(pfa => pfa.Id);

        builder.HasOne(pfa => pfa.Product)
            .WithMany(p => p.ProductFeatures)
            .HasForeignKey(pfa => pfa.ProductId);

        builder.HasOne(pfa => pfa.Feature)
            .WithMany(f => f.ProductFeatures)
            .HasForeignKey(pfa => pfa.FeatureId);
           
    }
}