using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualVendingMachine.Service.CancelPurchaseService
{
    public interface ICancelPurchaseService
    {
        bool CancelPurchase();
    }
}