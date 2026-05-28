using System.ComponentModel.DataAnnotations;

namespace Inventory_API.Models;

public class Product
{
    public int Id {get; set;}
    [Required]
    public required string ItemName {get; set;}
    public string Description {get; set;} = string.Empty;
    [Required]
    public required int Quantity {get; set;}
    [Required]
    public required decimal Price {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
}