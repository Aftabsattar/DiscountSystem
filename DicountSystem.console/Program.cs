using regular;
using premium;
using employee;
using Default;
using DiscountSystem;
Console.WriteLine("select The type of Customer");
Console.WriteLine("1. Regular");
Console.WriteLine("2. Premium");
Console.WriteLine("3. Employee");
Console.WriteLine("4. Walking");
Discount<double>[] discount = new Discount<double>[4];
string? Type = Console.ReadLine();
switch (Type)
{
    case "1":
        discount[0] = new RegularCustomer();
        Console.Write($"Total amount to pay:{discount[0].GetDiscount()}");
        break;
    case "2":
        discount[1] = new PremiumCustomer();
        Console.Write($"Total amount to pay:{discount[1].GetDiscount()}");
        break;
    case "3":
        discount[2] = new Employee();
        Console.Write($"Total amount to pay:{discount[2].GetDiscount()}");
        break;
    case "4":
        discount[3] = new DefaultCustomer(); 
        Console.Write($"Total amount to pay:{discount[3].GetDiscount()}");
        break;
    default:
        Console.WriteLine("Invalid Customer Type");
        break;
}

//change this file








