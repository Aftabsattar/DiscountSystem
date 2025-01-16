using regular;
using premium;
using employee;
using Default;
using DiscountSystem;
List<Discount<double>> list = new List<Discount<double>>();
Discount<double> discount=null;
do
{
    Console.WriteLine("select The type of Customer");
    Console.WriteLine(" Regular");
    Console.WriteLine(" Premium");
    Console.WriteLine(" Employee");
    Console.WriteLine(" Walking");
    string? Type = Console.ReadLine();
    switch (Type.ToLower())
    {
        case "regular":
            {
                discount = new RegularCustomer();
                Console.WriteLine("Enter the purchase amount");
                discount.purchaseAmount = Convert.ToDouble(Console.ReadLine());
                break;
            }
        case "premium":
            {
                 discount = new PremiumCustomer();
                Console.WriteLine("Enter the purchase amount");
                discount.purchaseAmount = Convert.ToDouble(Console.ReadLine());
                break;
            }
        case "employee":
            {
                discount = new Employee();
                Console.WriteLine("Enter the purchase amount");
                discount.purchaseAmount = Convert.ToDouble(Console.ReadLine());
                break;
            }
        case "walking":
            {
                discount = new DefaultCustomer();
                Console.WriteLine("Enter the purchase amount");
                discount.purchaseAmount = Convert.ToDouble(Console.ReadLine());
                break;
            }
        default:
            {
                Console.WriteLine("Invalid Customer type");
                break;
            }
    }
    // calculation
    Console.WriteLine($"Total Amount: {discount.GetDiscount()}");
    // add to list
    if (discount != null)
    {
        list.Add(discount);
    }
    // agian calculation 
    Console.WriteLine("Do you want to calculate again: (Y/N)");
    ConsoleKeyInfo Uchoice = Console.ReadKey();
    if (Uchoice.Key != ConsoleKey.Y)
    {
        Console.WriteLine($"\n#\tType \t  Amount\t Disounted");
        int a = 1;
        foreach (var i in list)
        {
            Console.WriteLine($"{a++}, {i.GetType().Name}, {i.purchaseAmount}, {i.GetDiscount()}");
        }
        break;

    }  
} while (true) ;



