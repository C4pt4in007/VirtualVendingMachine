using System.Text;
using VirtualVendingMachine.Models;

namespace VirtualVendingMachine.Service
{
    public class ChangeCalculator
    {

        // To calculate change in descending order to return smallest number of coins
        public static PurchaseResponseEntity CalculateChange(decimal productPrice, decimal amountInserted, int nicklesInMachine, int dimesInMachine, int quartersInMachine)
        {
            try 
            {
                int changeLeft = Convert.ToInt16((amountInserted - productPrice) * 100);


                int quartersNeeded = changeLeft / 25;
                if (quartersNeeded > quartersInMachine)
                {
                    quartersNeeded = quartersInMachine;
                }
                changeLeft -= quartersNeeded * 25;


                int dimesNeeded = changeLeft / 10;
                if (dimesNeeded > dimesInMachine)
                {
                    dimesNeeded = dimesInMachine;
                }
                changeLeft -= dimesNeeded * 10;


                int nicklesNeeded = changeLeft / 5;
                if (nicklesNeeded > nicklesInMachine)
                {
                    nicklesNeeded = nicklesInMachine;
                }
                changeLeft -= nicklesNeeded * 5;


                if (changeLeft > 0)
                {
                    throw new Exception("Not enough change in the system");
                }

                return new PurchaseResponseEntity
                {
                    DimesToReturn = dimesNeeded,
                    NicklesToReturn = nicklesNeeded,
                    QuartersToReturn = quartersNeeded,
                };

            } 
            catch(Exception ex) 
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
