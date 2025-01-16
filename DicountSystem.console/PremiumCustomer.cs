using DiscountSystem;
namespace premium
{
    class PremiumCustomer : Discount<double>
    {
        public override double GetDiscount()
        {
            return purchaseAmount - purchaseAmount * 20 / 100;
        }
    }
}
//derived