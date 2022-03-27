namespace Inventory.Domain;

public class RhUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}