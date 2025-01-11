
using DiscountSystem;
namespace regular
{
    class RegularCustomer : Discount<double>
    {
        public override double GetDiscount()
        {
            Console.WriteLine("Enter the purchase amount");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());
            return purchaseAmount - purchaseAmount * 10 / 100;
        }
    }

}//derived

