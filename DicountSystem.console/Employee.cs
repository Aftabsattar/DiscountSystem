namespace employee
{
    class Employee
    {
        public double GetDiscount(double purchaseAmount)
        {
            double DicountAmount = purchaseAmount * 30 / 100;
            double totalAmountToPay = purchaseAmount - DicountAmount;
            return totalAmountToPay;
        }
    }
}