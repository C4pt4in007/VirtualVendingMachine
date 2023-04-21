using VirtualVendingMachine.Models;

namespace VirtualVendingMachine.Model
{
    public class InsertMoneyResponseEntity
    {
        private decimal _amountInserted;
        private ErrorMessageResponseEntity _error =  new ErrorMessageResponseEntity { };

        public ErrorMessageResponseEntity Message
        { get { return _error; } set { _error = value; } }

        public decimal AmountInserted
        { get { return _amountInserted; } set { _amountInserted = value; } }

    }
}
