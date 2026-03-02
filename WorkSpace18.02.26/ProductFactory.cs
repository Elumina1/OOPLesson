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
    //todo создать фабрику для молочки и хлеба 

    public class Smartphone : ProductFactory
    {
        public override Product Create()
        {
            return new SmartPhone();
        }
    }
}
