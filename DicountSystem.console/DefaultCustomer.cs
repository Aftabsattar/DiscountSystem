using DiscountSystem;
namespace Default
{
    class DefaultCustomer : Discount<double>
    {
        public override double GetDiscount() {
            return purchaseAmount; 
        }
    }
}//derived
