
namespace DiscountSystem
{
    abstract class Discount<T>
    {
        public T purchaseAmount { get; set; }
        public abstract T GetDiscount();
        

    }
}
//base class