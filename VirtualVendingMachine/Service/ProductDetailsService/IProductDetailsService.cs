using VirtualVendingMachine.Models;

namespace VirtualVendingMachine.Service.ProductDetailsService
{
    public interface IProductDetailsService
    {
        ProductDetailsResponseEntity GetProductDetails(int productId);
    }
}