namespace StockManagament.API.Entities;

public class BorrowUserAssoc : BaseEntity
{
    public int BorrowId { get; set; }
    public Borrow Borrow { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}