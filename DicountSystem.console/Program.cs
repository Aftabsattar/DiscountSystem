using regular;
using premium;
using employee;
using Default;
using DiscountSystem;
Console.WriteLine("select The type of Customer");
Console.WriteLine(" Regular");
Console.WriteLine(" Premium");
Console.WriteLine(" Employee");
Console.WriteLine(" Walking");
List<Discount<double>> list = new List<Discount<double>>()
{
new RegularCustomer(),
new PremiumCustomer(),
new Employee(),
new DefaultCustomer()
};

string? Type = Console.ReadLine();
string Amount = Type.ToLower() switch
{
    "regular" => $"Total amount to pay:{list[0].GetDiscount()}",
    "premium" => $"Total amount to pay:{list[1].GetDiscount()}",
    "employee" => $"Total amount to pay:{list[2].GetDiscount()}",
    "walking" => $"Total amount to pay:{list[3].GetDiscount()}",
    _ => "Invalid Customer Type ",
};
Console.WriteLine(Amount);
//change this file








