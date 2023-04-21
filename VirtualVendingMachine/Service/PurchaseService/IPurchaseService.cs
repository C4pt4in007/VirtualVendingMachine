using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtualVendingMachine.Models;

namespace VirtualVendingMachine.Service.PurchaseService
{
    public interface IPurchaseService
    {
        PurchaseResponseEntity BuyProductAndReturnChange(int productId);
    }
}