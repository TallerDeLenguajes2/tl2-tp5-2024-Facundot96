﻿using TP5.Models;

namespace TP5.Repository;

public interface IProductRepository
{
    public void createProduct(Product product);
    public void deleteProduct(int idProduct);
    public void updateProduct(int idProduct,Product product);
    public List<Product> getAllProducts();
    public Product getProductById(int idProduct);
}