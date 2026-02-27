using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
{
    internal class OrderDiscount : IDiscountSystem
    {
        public decimal GetDiscount(Order order)
        {
            throw new NotImplementedException();
        }

        public string GetDiscountDescription()
        {
            return "Скидка на товар";
        }
    }
}
