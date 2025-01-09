using DiscountSystem;
namespace employee
{
    class Employee : Discount<double>
    {
        public override double GetDiscount()
        {
            Console.WriteLine("Enter the purchase amount");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());
            return purchaseAmount - purchaseAmount * 30 / 100;
        }
    }
}
