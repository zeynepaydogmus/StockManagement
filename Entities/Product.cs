namespace StockManagament.API.Entities;

public class Product: BaseEntity
{
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; }
    public ICollection<ProductFeatureAssoc> ProductFeatures { get; set; }
}