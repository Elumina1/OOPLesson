using LinqToDB;
using WorkSpace18._02._26.Builders;
using WorkSpace18._02._26.Data;
using WorkSpace18._02._26.Models;
using WorkSpace18._02._26.Services;

namespace WorkSpace18._02._26;

class Program
{
    public static void RunDbConnection()
    {
        var options = new DataOptions()
            .UsePostgreSQL(@"Server=localhost;Port=5432;DataBase=shop; User Id=re;Password=postgres; Include Error Detail=True");

        using var db = new DbOrders(options);
        
        // Product
        db.Products.Insert(() => new Product
        {
            Title = "New Prodcut 1",
            Article = "15",
            Brand = "Brand",
            Price = 666
        });
        
        var products = db.Products
            .ToList();
        
        ShowItems(products, "Products");
        
        // Client
        db.Clients.Insert(() => 
            new Client(
                "name",
                "email",
                "74734742",
                "fwfww")
        );

        var client = db.Clients
            .FirstOrDefault(x => x.Id == 1);
        
        /*ShowItems(clients, "Clients");*/
        
        // Order
        var milkFactory = new DairyFactory();
        var milk = milkFactory.Create();
        
        var milkItem = new OrderItem() 
        {
            Amount = 3, 
            Product = milk
        };
        
        milk.Price = 180;
        milkItem.Amount = 2;
        var vasyaDiscount = new PersistentCustomerDiscount();
        
        
            
        db.Orders.Insert(() => new Order());
        
        var orders = db.Orders
            .ToList();
        
        ShowItems(orders);
        
        /*
        // Order
        var orderItems = db.OrderItems
            .LoadWith(request => request.Product)
            .ToList();
        
        ShowItems(orderItems);
        
        */
    }

    private static void ShowItems<T>(
        IEnumerable<T> items,
        string title = "Items:")
    {
        Console.WriteLine($"{title}: \n");
        
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
    
    static void Main(string[] args)
    {
        RunDbConnection();
        return;
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
        var milkFactory = new DairyFactory();
        var milk5 = milkFactory.Create();


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
