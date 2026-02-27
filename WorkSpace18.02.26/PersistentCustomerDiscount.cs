using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
{
    public class PersistentCustomerDiscount : IDiscountSystem
    {
        public decimal GetDiscount(Order order)
        {
            return order.TotalSum * 0.05m;
        }
        public string GetDiscountDescription()
        {
            return "Скидка постоянного клиента";
        }
    }
}
