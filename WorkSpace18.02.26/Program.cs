using System;
namespace WorkSpace18._02._26;
class Program
{
    static void Main(string[] args)
    {
        var vasya = new Client("Вася", "uweullar@gmail.com", "89000000000", "Ленина 100");
        vasya.AddBalance(1000000000);
        Console.WriteLine(vasya);
        var vasyaDiscount = new PersistentCustomerDiscount();

        var milk = new Product()
        {
            Title = "Молоко 3,5%",
            Brand = "Вятушка",
            Price = 90
        };

        var bread = new Product()
        {
            Title = "Черный бородинский",
            Brand = "ООО москва",
            Price = 50
        };

        var automobil = new Automobile
        { 
            Title = "Kalina",
            Brand = "Lada",
            Price = 150000,
            Color = "Pink",
            Engine = "Есть",
            Height = 100,
            Len = 150,
            Width = 100,
            CarBody = "Купе",
            Transmission = "МКПП",
            Volume = 100,
        };

        var smartphone = new SmartPhone
        {
            Title = "15 PRO MAX",
            Brand = "Iphone",
            Price = 100000,
            Color = "Черный",
            CPU = "Есть",
            MPCamera = 16,
            Memory = 256,
            OperatingSystem = "IOS",
        };

        var audiFactory = new AutomobileFactory(/*передать какие то параметры */);
        var blackAudi = audiFactory.Create();

        Console.WriteLine(blackAudi);
        return;

        var breadItem = new OrderItem() { Amount = 2, Product = bread };
        Console.WriteLine(breadItem.Sum);

        var milkItem = new OrderItem() { Amount = 3, Product = milk };
        milk.Price = 180;
        milkItem.Amount = 2;
        Console.WriteLine(milkItem.Sum);

        //var order = new Order()
        //{
        //    Client = vasya,
        //    Number = "1235",
        //    Date = DateTime.Now,
        //    Items = new List<OrderItem>
        //    {
        //        milkItem, 
        //        breadItem
        //    },
        //    DiscountSystem = vasyaDiscount
        //};

        var order = new OrderBuilder()
            .ForCustomer(vasya)
            .WithItems(new List<OrderItem>
            {
                milkItem,
                breadItem
            })
            .WithDiscount(vasyaDiscount)
            .WithPaymentKind(new FSP())
            .Build();

        Console.WriteLine(order);

        breadItem.Amount = 3;
        Console.WriteLine(order);


        var order2 = new OrderBuilder()
            .ForCustomer(vasya)
            .WithItems(new List<OrderItem>
            {
                milkItem,
                breadItem,
                milkItem,

            })
            .WithDiscount(vasyaDiscount)
            .WithPaymentKind(new Cash())
            .Build();

        Console.WriteLine(order2);
        //todo подумать над вариантом оплаты и реализацией 
        //todo вычитать сумму платежа с баланса клиента
    }
}
