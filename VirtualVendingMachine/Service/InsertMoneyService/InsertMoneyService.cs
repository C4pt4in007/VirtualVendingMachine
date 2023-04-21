using VirtualVendingMachine.Model;
using VirtualVendingMachine.Models;
using VirtualVendingMachine.Repository;
using VirtualVendingMachine.Service.MoneyTypeService;

namespace VirtualVendingMachine.Service.InsertMoneyService
{
    public class InsertMoneyService : IInsertMoneyService
    {
        private readonly IMoneyTypeService moneyTypeService;
        private readonly TemporaryTransactionStorage transactionStorage;
        private IProductDetailsRespository productDetailsRespository;

        public InsertMoneyService(IMoneyTypeService moneyTypeService, TemporaryTransactionStorage transactionStorage, IProductDetailsRespository productDetailsRespository)
        {
            this.moneyTypeService = moneyTypeService;
            this.transactionStorage = transactionStorage;
            this.productDetailsRespository = productDetailsRespository;
        }
        public InsertMoneyResponseEntity InsertMoneyInTheMachine(int productId, decimal amount)
        {
            // check if no transaction or if productid matches with current transaction
            if (((transactionStorage.ProductId == -1) || (productId == transactionStorage.ProductId)))
            {
                decimal productPrice = productDetailsRespository.GetProductById(Convert.ToSByte(productId)).ProductPrice;
                if (productPrice > 0.00m && productPrice >= transactionStorage.AmountInserted)
                {
                    string moneyType = moneyTypeService.CheckMoneyIsAcceptable(amount);                    

                    switch (moneyType)
                    {
                        case "NICKLE":
                            transactionStorage.NumNickels = 1;
                            break;
                        case "DIME":
                            transactionStorage.NumDimes = 1;
                            break;
                        case "QUARTER":
                            transactionStorage.NumQuarters = 1;
                            break;
                        case "DOLLAR":
                            transactionStorage.NumDollars = 1;
                            break;
                        default:
                            return new InsertMoneyResponseEntity
                            {
                                Message = new ErrorMessageResponseEntity
                                {
                                    Message = "This machine doesn't accept this currency"
                                }
                            };
                    }
                    transactionStorage.ProductId = Convert.ToSByte(productId);
                    transactionStorage.AmountInserted = amount;
                    return new InsertMoneyResponseEntity { AmountInserted = transactionStorage.AmountInserted };
                }

                return new InsertMoneyResponseEntity
                {
                    AmountInserted = -1.0m,
                    Message = new ErrorMessageResponseEntity
                    {
                        Message = "Product doesn't exist or Amount inserted is already sufficient"
                    }

                };
            }
            return new InsertMoneyResponseEntity
            {
                AmountInserted = 0.0m,
                Message = new ErrorMessageResponseEntity
                {
                    Message = "A transaction is already in progress, please cancel existing transaction."
                }

            };
        }
    }
}