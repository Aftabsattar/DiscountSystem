namespace premium
{
    class PremiumCustomer
    {
        public double GetDiscount(double purchaseAmount)
        {
            double DicountAmount = purchaseAmount * 20 / 100;
            double totalAmountToPay = purchaseAmount - DicountAmount;
            return totalAmountToPay;
        }
    }
}