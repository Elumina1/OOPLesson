using System;
namespace WorkSpace18._02._26;
class Program
{
    static void Main(string[] args)
    {
        var vasya = new Client("Вася", "uweullar@gmail.com", "89000000000", "Ленина 100");
        vasya.AddBalance(1000000000);
        Console.WriteLine(vasya);

        var milk = new sum()
        {
            Title = "Молоко 3,5%",
            Brand = "Вятушка",
            Price = 90
        };

        var bread = new sum()
        {
            Title = "Черный бородинский",
            Brand = "ООО москва",
            Price = 50
        };

        var breadItem = new OrderItem() { Amount = 2, Product = bread };
        Console.WriteLine(breadItem.Sum);

        var milkItem = new OrderItem() { Amount = 3, Product = milk };
        milk.Price = 180;
        milkItem.Amount = 2;
        Console.WriteLine(milkItem.Sum);

        var order = new Order()
        {
            Client = vasya,
            Number = "1235",
            Date = DateTime.Now,
            Items = new List<OrderItem>
            {
                milkItem, 
                breadItem
            }
        };



        Console.WriteLine(order);

        breadItem.Amount = 3;
        Console.WriteLine(order);

        //todo подумать над вариантом оплаты и реализацией 
        //todo вычитать сумму платежа с баланса клиента
    }
}
