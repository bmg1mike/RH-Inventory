namespace Inventory.Domain;

public class BaseEntity
{
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public DateTime DateModified { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
}