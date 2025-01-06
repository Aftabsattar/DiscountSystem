using regular;
using premium;
using employee;
using Default;

Console.WriteLine("select The type of Customer");
Console.WriteLine("1. Regular");
Console.WriteLine("2. Premium");
Console.WriteLine("3. Employee");
Console.WriteLine("4. Walking");
string? Type = Console.ReadLine();
switch (Type)
{
    case "1":
        RegularCustomer regular = new RegularCustomer();
        Console.WriteLine("Enter the purchase amount");
        double purchaseAmount = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Total amount to pay:{regular.GetDiscount(purchaseAmount)}");
        break;
    case "2":
        PremiumCustomer premium = new PremiumCustomer();
        Console.WriteLine("Enter the purchase amount");
        double purchaseAmountP = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Total amount to pay:{premium.GetDiscount(purchaseAmountP)}");
        break;
    case "3":
        Employee emp = new Employee();
        Console.WriteLine("Enter the purchase amount");
        double purchaseAmountE = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Total amount to pay:{emp.GetDiscount(purchaseAmountE)}");
        break;
    case "4":
        DefaultCustomer defCous = new DefaultCustomer();
        Console.WriteLine("Enter the purchase amount");
        double purchaseAmountD = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Total amount to pay:{defCous.GetDiscount(purchaseAmountD)}");
        break;
    default:
        Console.WriteLine("Invalid Customer Type");
        break;
}













