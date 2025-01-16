using DiscountSystem;
namespace employee
{
    class Employee : Discount<double>
    {
        public override double GetDiscount()
        {
            return purchaseAmount - purchaseAmount * 30 / 100;
        }
    }
}
//derived