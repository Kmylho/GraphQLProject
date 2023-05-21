using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class ProductService : IProduct 
    {
        private static List<Product> products = new List<Product>()
        {
            new Product(){Id = 0, Name = "Coffee", Price = 10},
            new Product(){Id = 1, Name = "Tea", Price = 15},
            new Product(){Id = 2, Name = "Chocolate", Price = 20},
        };
        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.Find(p  => p.Id == id);
        }

        public Product UpdateProduct(int id, Product product)
        {
            products[id] = product;
            return product;
        }
    }
}
