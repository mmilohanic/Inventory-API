using Inventory_API.Models;

namespace Inventory_API.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product?> GetProductByIDAsync(int id);
    Task AddProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(Product product);
}