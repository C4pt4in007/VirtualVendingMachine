namespace VirtualVendingMachine.Models
{
    public class PurchaseResponseEntity
    {
        private int dimesToReturn = -1;
        private int nicklesToReturn = -1;
        private int quartersToReturn = -1;
        private ErrorMessageResponseEntity error = new ErrorMessageResponseEntity { };

        public int DimesToReturn
        {
            get { return dimesToReturn; }
            set { dimesToReturn = value; }
        }
        public int NicklesToReturn
        {
            get { return nicklesToReturn; }
            set { nicklesToReturn = value; }
        }
        public int QuartersToReturn
        {
            get { return quartersToReturn; }
            set { quartersToReturn = value; }
        }

        public ErrorMessageResponseEntity Error
        {
            get { return error; }
            set { error = value; }
        }
    }
}
