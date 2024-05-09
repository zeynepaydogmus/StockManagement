namespace StockManagament.API.Entities;

public class ProductFeatureAssoc : BaseEntity
{
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int FeatureId { get; set; }
    public Feature Feature { get; set; }
}