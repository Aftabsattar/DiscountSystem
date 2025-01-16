
using DiscountSystem;
namespace regular
{
    class RegularCustomer : Discount<double>
    {
        public override double GetDiscount()
        {
            return purchaseAmount - purchaseAmount * 10 / 100;
        }
    }

}//derived

