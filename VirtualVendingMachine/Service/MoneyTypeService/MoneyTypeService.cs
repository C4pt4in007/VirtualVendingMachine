namespace VirtualVendingMachine.Service.MoneyTypeService
{
    public class MoneyTypeService : IMoneyTypeService
    {
        enum TypeOfMoney { DIME, NICKLE, QUARTER, DOLLAR, ERROR };
        public string CheckMoneyIsAcceptable(decimal amount)
        {

            switch (amount)
            {
                case 0.05m:
                    return TypeOfMoney.NICKLE.ToString();

                case 0.10m:
                    return TypeOfMoney.DIME.ToString();

                case 0.25m:
                    return TypeOfMoney.QUARTER.ToString();

                case 1.00m:
                    return TypeOfMoney.DOLLAR.ToString();

                default:
                    return TypeOfMoney.ERROR.ToString();
            }

        }
    }
}
