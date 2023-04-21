namespace VirtualVendingMachine.Repository
{
    // To initialise and store coins and dollars in the machine
    public class VendingMachineStorage
    {
        private static int _numNickels = 3;
        private static int _numDimes = 5;
        private static int _numQuarters = 2;
        private static int _numDollars = 0;

        public int NumNickels
        {
            get { return _numNickels; }
            set { _numNickels = value; }
        }

        public int NumDimes
        {
            get { return _numDimes; }
            set { _numDimes = value; }
        }

        public int NumQuarters
        {
            get { return _numQuarters; }
            set { _numQuarters = value; }
        }

        public int NumDollars
        {
            get { return _numDollars; }
            set { _numDollars = value; }
        }
        
    }
}
