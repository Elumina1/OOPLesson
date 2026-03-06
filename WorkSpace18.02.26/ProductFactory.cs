using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
{
    public abstract class ProductFactory
    {
        public virtual Product Create()
        {
            return new Product();
        }
    }

    public class AutomobileFactory : ProductFactory
    {
        public override Product Create()
        {
            return new Automobile();
        }
    }

    // фабрика для смартфонов 
    public class Smartphone : ProductFactory
    {
        public override Product Create()
        {
            return new SmartPhone();
        }
    }

    //реализация продукта для молочной продукции
    public class DairyProduct : Product
    {
        //жинрность молока в процентах
        public decimal FatPercentage { get; set; }

        // срок годности в днях
        public int ShelfLifeDays { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Brand}), жирность {FatPercentage}%, срок {ShelfLifeDays} дн., цена {Price}";
        }
    }

    //фабрика для молочной продукции
    public class DairyFactory : ProductFactory
    {
        public override Product Create()
        {
            return new DairyProduct
            {
                Title = "Молоко",
                Brand = "Стандарт",
                Article = "DAIRY-001",
                Price = 49.90m,
                FatPercentage = 3.2m,
                ShelfLifeDays = 7
            };
        }
    }

    // реализация продукта для хлеба
    public class BreadProduct : Product
    {
        // тип муки (пшеничная, ржаная и т.д.)
        public string FlourType { get; set; }

        // является ли хлеб цельнозерновым
        public bool IsWholeGrain { get; set; }

        public override string ToString()
        {
            var grain = IsWholeGrain ? "цельнозерновой" : "обычный";
            return $"{Title} ({Brand}), {FlourType}, {grain}, цена {Price}";
        }
    }

    // фабрика для хлеба
    public class BreadFactory : ProductFactory
    {
        public override Product Create()
        {
            return new BreadProduct
            {
                Title = "Бородинский хлеб",
                Brand = "Пекарня",
                Article = "BREAD-001",
                Price = 29.50m,
                FlourType = "ржаная",
                IsWholeGrain = true
            };
        }
    }
}
