using Cosmos.Shared.Models;

namespace Cosmos.WebApi
{
    public class ProductService
    {
        public List<Product> Products { get; set; } = new();

        public void UpdateProduct(Product product)
        {
            var productsToUpdate = Products.FirstOrDefault(p => p.ProductId.Equals(product.ProductId));
            if (productsToUpdate is not  null)
            {
                productsToUpdate.Name = product.Name;
                productsToUpdate.Description = product.Description;
                productsToUpdate.Price = product.Price;
                productsToUpdate.Stock = product.Stock;

            }
        }
        public void AddProduct(Product? product)
        {
            if(product is not null)
                Products.Add(product);
        }
        public void DeleteProduct(int productId)
        {
            if (Products.Any(p => p.ProductId.Equals(productId)))
            {
                var productToDelete = Products.FirstOrDefault(p => p.ProductId.Equals(productId));
                if (productToDelete is not null)
                    Products.Remove(productToDelete);
            }

        }
    }
}
