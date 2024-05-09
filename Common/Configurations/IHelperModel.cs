namespace StockManagament.API.Common.Configurations;

public interface IHelperModel
{
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public int CreatedById { get; set; }
    public int? ModifiedById { get; set; }
    public bool IsDeleted { get; set; }
}