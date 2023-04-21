using VirtualVendingMachine.Model;

namespace VirtualVendingMachine.Service.InsertMoneyService
{
    public interface IInsertMoneyService
    {
        InsertMoneyResponseEntity InsertMoneyInTheMachine(int productId, decimal money);
    }
}
