using Inventory_API.Models;
using Inventory_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IProductRepository repository) : ControllerBase
{
    private readonly IProductRepository _repository = repository;

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _repository.GetAllProductsAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductByID(int id)
    {
        var product = await _repository.GetProductByIDAsync(id);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct(Product product)
    {
        await _repository.AddProductAsync(product);
        return CreatedAtAction(nameof(GetProductByID), new { id = product.Id }, product);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProduct(Product product)
    {
        var existing = await _repository.GetProductByIDAsync(product.Id);
        
        if (existing == null)
            return NotFound();

        existing.ItemName = product.ItemName;
        existing.Description = product.Description;
        existing.Quantity = product.Quantity;
        existing.Price = product.Price;

        await _repository.UpdateProductAsync(existing);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _repository.GetProductByIDAsync(id);
        
        if (product == null)
            return NotFound();
        
        await _repository.DeleteProductAsync(product);
        return NoContent();
    }
}