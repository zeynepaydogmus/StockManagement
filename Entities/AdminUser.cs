namespace StockManagament.API.Entities;

public class AdminUser : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; }
}