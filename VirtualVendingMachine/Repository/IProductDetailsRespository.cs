using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualVendingMachine.Models;

namespace VirtualVendingMachine.Repository
{
    public interface IProductDetailsRespository
    {
        ProductDetailsResponseEntity GetProductById(sbyte productId);
    }
}
