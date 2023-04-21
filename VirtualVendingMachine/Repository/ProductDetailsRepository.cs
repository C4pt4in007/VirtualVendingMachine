using VirtualVendingMachine.Models;

namespace VirtualVendingMachine.Repository
{
    // Intialises products in the machine
    public class ProductDetailsRepository : IProductDetailsRespository
    {
        private readonly List<ProductDetailsResponseEntity> productList;

        public ProductDetailsRepository()
        {
            productList = new List<ProductDetailsResponseEntity>
            {
                new ProductDetailsResponseEntity { ProductId = 1, ProductName = "Coke", ProductPrice = 0.95m },
                new ProductDetailsResponseEntity { ProductId = 2, ProductName = "Diet Coke", ProductPrice = 0.90m },
                new ProductDetailsResponseEntity { ProductId = 3, ProductName = "Candy Bar", ProductPrice = 0.95m },
                new ProductDetailsResponseEntity { ProductId = 4, ProductName = "Gum", ProductPrice = 0.30m },
                new ProductDetailsResponseEntity { ProductId = 5, ProductName = "Chips", ProductPrice = 1.10m },
                new ProductDetailsResponseEntity { ProductId = 6, ProductName = "Energy Drink", ProductPrice = 1.00m }
            };
        }
        public ProductDetailsResponseEntity GetProductById(sbyte productId)
        {
            return productList.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}