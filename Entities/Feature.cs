namespace StockManagament.API.Entities;

public class Feature : BaseEntity
{
   public string Name { get; set; }
   public ICollection<ProductFeatureAssoc> ProductFeatures { get; set; }
}