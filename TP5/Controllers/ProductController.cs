using Microsoft.AspNetCore.Mvc;
using TP5.Models;
using TP5.Repository;

namespace TP5.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController: ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        var products = _productRepository.getAllProducts();
        return Ok(products);
    }

    [HttpPost]
    public ActionResult CreateProduct(Product product)
    {
        _productRepository.createProduct(product);
        return Created();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateProduct(int id, Product product)
    {
        var oldProduct = _productRepository.getProductById(id);
        oldProduct = product;
        _productRepository.updateProduct(id, oldProduct);
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id)
    {
        _productRepository.deleteProduct(id);
        return Ok();
    }
    
}