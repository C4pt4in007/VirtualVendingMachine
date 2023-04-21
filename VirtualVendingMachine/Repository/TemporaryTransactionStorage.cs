namespace VirtualVendingMachine.Repository
{
    // Money inserted for current transaction
    public class TemporaryTransactionStorage
    {
        private static int _numNickels = 0;
        private static int _numDimes = 0;
        private static int _numQuarters = 0;
        private static int _numDollars = 0;

        private static decimal _amountInserted = 0.0m;
        private static sbyte _productId = -1;
        public int NumNickels
        {
            get { return _numNickels; }
            set { _numNickels += value; }
        }
        public sbyte ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public int NumDimes
        {
            get { return _numDimes; }
            set { _numDimes += value; }
        }

        public int NumQuarters
        {
            get { return _numQuarters; }
            set { _numQuarters += value; }
        }

        public int NumDollars
        {
            get { return _numDollars; }
            set { _numDollars += value; }
        }

        public decimal AmountInserted
        {
            get { return _amountInserted; }
            set { _amountInserted += value; }
        }

        public bool ResetAmountInserted() 
        {
            _numNickels= 0;
            _numDimes= 0;
            _numQuarters= 0;
            _numDollars= 0;
            _amountInserted = 0.0m;
            _productId = -1;
            return true;
        }
    }
}
