namespace VirtualVendingMachine.Service.MoneyTypeService
{
    public interface IMoneyTypeService
    {
        string CheckMoneyIsAcceptable(decimal money);
    }
}
