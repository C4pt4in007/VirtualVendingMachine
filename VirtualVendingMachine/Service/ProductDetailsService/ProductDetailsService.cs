using VirtualVendingMachine.Models;
using VirtualVendingMachine.Repository;

namespace VirtualVendingMachine.Service.ProductDetailsService
{
    public class ProductDetailsService : IProductDetailsService
    {
        private readonly IProductDetailsRespository productDetailsRespository;
        public ProductDetailsService(IProductDetailsRespository productDetailsRespository)
        {
            this.productDetailsRespository = productDetailsRespository;
        }

        public ProductDetailsResponseEntity GetProductDetails(int productId)
        {
            return productDetailsRespository.GetProductById(Convert.ToSByte(productId));                        
        }
    }
}