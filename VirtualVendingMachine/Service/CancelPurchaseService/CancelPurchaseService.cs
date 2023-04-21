using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtualVendingMachine.Repository;

namespace VirtualVendingMachine.Service.CancelPurchaseService
{
    public class CancelPurchaseService : ICancelPurchaseService
    {
        private readonly TemporaryTransactionStorage temporaryTransactionStorage;
        public CancelPurchaseService(TemporaryTransactionStorage temporaryTransactionStorage)
        {
            this.temporaryTransactionStorage = temporaryTransactionStorage;
        }
        public bool CancelPurchase()
        {
            return temporaryTransactionStorage.ResetAmountInserted();
        }
    }
}