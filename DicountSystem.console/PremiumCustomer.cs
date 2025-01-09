using DiscountSystem;
namespace premium
{
    class PremiumCustomer : Discount<double>
    {
        public override double GetDiscount()
        {
            Console.WriteLine("Enter the purchase amount");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());
            return purchaseAmount - purchaseAmount * 20 / 100;
        }
    }
}
