using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VirtualVendingMachine.Models;
using VirtualVendingMachine.Repository;

namespace VirtualVendingMachine.Service.PurchaseService
{
    public class PurchaseService : IPurchaseService
    {

        private IProductDetailsRespository productDetailsRespository;
        private VendingMachineStorage vendingMachineStorage;
        private TemporaryTransactionStorage temporaryTransactionStorage;
        private TemporaryMoneyService temporaryMoneyService;

        public PurchaseService(IProductDetailsRespository productDetailsRespository, VendingMachineStorage vendingMachineStorage, TemporaryTransactionStorage temporaryTransactionStorage, TemporaryMoneyService temporaryMoneyService)
        {
            this.productDetailsRespository = productDetailsRespository;
            this.vendingMachineStorage = vendingMachineStorage;
            this.temporaryTransactionStorage = temporaryTransactionStorage;
            this.temporaryMoneyService = temporaryMoneyService;
        }

        public PurchaseResponseEntity BuyProductAndReturnChange(int productId)
        {
            try
            {
                if (temporaryTransactionStorage.ProductId == productId)
                {
                    decimal productPrice = productDetailsRespository.GetProductById(Convert.ToSByte(productId)).ProductPrice;
                    if (temporaryTransactionStorage.AmountInserted < productPrice)
                    {
                        throw new Exception("Amount Inserted is Less than Product Price.");
                    }
                    else if (temporaryTransactionStorage.ProductId == productId && temporaryTransactionStorage.AmountInserted == productPrice)
                    {
                        return new PurchaseResponseEntity
                        {
                            QuartersToReturn = 0,
                            DimesToReturn = 0,
                            NicklesToReturn = 0
                        };
                    }
                    PurchaseResponseEntity purchaseResponseEntity = ChangeCalculator.CalculateChange(productPrice, temporaryTransactionStorage.AmountInserted, vendingMachineStorage.NumNickels, vendingMachineStorage.NumDimes, vendingMachineStorage.NumQuarters);
                    temporaryMoneyService.ManageTemproaryMoney(purchaseResponseEntity);
                    return purchaseResponseEntity;
                }
                else if(temporaryTransactionStorage.ProductId == -1)
                {

                    throw new Exception("No Product selected to purchase");

                }
                else {

                    throw new Exception("ProductId sent is different");

                }

            }
            catch (Exception ex)
            {
                return new PurchaseResponseEntity
                {
                    Error = new ErrorMessageResponseEntity
                    {
                        Message = ex.Message
                    }
                };
            }

        }

       
    }
}