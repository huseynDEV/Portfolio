// See https://aka.ms/new-console-template for more information
using _07_NullableEnumStruct;

class Program
{
    static void Main(string[] args)
    {


        DrinkOrder order1 = new DrinkOrder(101, "Hüseyn", DrinkType.Coffee, DrinkSize.Medium);
        order1.DisplayOrder();

        order1.UpdateStatus(OrderStatus.Preparing);
        order1.UpdateStatus(OrderStatus.Ready);
        order1.UpdateStatus(OrderStatus.Delivered);


        DrinkOrder order2 = new DrinkOrder(102, "Həsən", DrinkType.Tea, DrinkSize.Large);
        order2.DisplayOrder();

        order2.UpdateStatus(OrderStatus.Ready);


        DrinkOrder order3 = new DrinkOrder(103, "Feyzullah", DrinkType.Juice, DrinkSize.Small);
        order3.DisplayOrder();


        Console.WriteLine("\n--- Statistika ---");

        Console.WriteLine("Ümumi sifariş: 3");

        Console.WriteLine("Sifariş 1 qiymət: " + order1.Price);
        Console.WriteLine("Sifariş 2 qiymət: " + order2.Price);
        Console.WriteLine("Sifariş 3 qiymət: " + order3.Price);

        decimal total = order1.Price + order2.Price + order3.Price;

        Console.WriteLine("Ümumi məbləğ: " + total + " AZN");
    }
}
