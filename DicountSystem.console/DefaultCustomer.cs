using DiscountSystem;
namespace Default
{
    class DefaultCustomer : Discount<double>
    {
        public override double GetDiscount() {
            Console.WriteLine("Enter the purchase amount");
            return Convert.ToDouble(Console.ReadLine()); 
        }
    }
}//derived
