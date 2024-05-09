namespace StockManagament.API.Entities;

public class Borrow : BaseEntity
{
 
   public int UserId { get; set; }
   public User User { get; set; }
   
   public int ProductId { get; set; }
   public Product Product { get; set; }
   public string Note { get; set; }
   public bool IsReturned { get; set; }
   public ICollection<BorrowUserAssoc> BorrowUser { get; set; }
   public DateTime BarrowDate { get; set; }
   public DateTime ReturnDate { get; set; }
   public DateTime ActualReturnDate { get; set; }
   

}