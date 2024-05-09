using Microsoft.AspNetCore.Identity;
using StockManagament.API.Common.Configurations;

namespace StockManagament.API.Entities;

public class User : IdentityUser<int>, IEntity
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string SurName { get; set; }
    
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    
    public int CreatedById { get; set; }
    public int? ModifiedById { get; set; }
    public bool IsDeleted { get; set; }
    
    public ICollection<AdminUser> AdminUsers { get; set; }
}