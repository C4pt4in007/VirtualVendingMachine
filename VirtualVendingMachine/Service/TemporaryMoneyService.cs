using VirtualVendingMachine.Models;
using VirtualVendingMachine.Repository;

namespace VirtualVendingMachine.Service
{
    public class TemporaryMoneyService
    {
        private VendingMachineStorage vendingMachineStorage;
        private TemporaryTransactionStorage temporaryTransactionStorage;

        public TemporaryMoneyService(VendingMachineStorage vendingMachineStorage, TemporaryTransactionStorage temporaryTransactionStorage) { 
            this.vendingMachineStorage = vendingMachineStorage;
            this.temporaryTransactionStorage = temporaryTransactionStorage;
        }
        public void ManageTemproaryMoney(PurchaseResponseEntity purchaseResponseEntity)
        {
            if (purchaseResponseEntity.Error.Message == string.Empty)
            {
                vendingMachineStorage.NumQuarters += temporaryTransactionStorage.NumQuarters;
                vendingMachineStorage.NumDollars += temporaryTransactionStorage.NumDollars;
                vendingMachineStorage.NumDimes += temporaryTransactionStorage.NumDimes;
                vendingMachineStorage.NumNickels += temporaryTransactionStorage.NumNickels;

                //return money
                vendingMachineStorage.NumQuarters -= purchaseResponseEntity.QuartersToReturn;
                vendingMachineStorage.NumDimes -= purchaseResponseEntity.DimesToReturn;
                vendingMachineStorage.NumNickels -= purchaseResponseEntity.NicklesToReturn;
            }
            
            temporaryTransactionStorage.ResetAmountInserted();
            
        }
    }
}
