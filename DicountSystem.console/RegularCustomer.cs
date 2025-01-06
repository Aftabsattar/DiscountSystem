
namespace regular
{
    class RegularCustomer
    {
        public double GetDiscount(double purchaseAmount)
        {
            double DicountAmount = purchaseAmount * 10/100;
            double totalAmountToPay = purchaseAmount - DicountAmount;
            return totalAmountToPay;
        }
    }

}

