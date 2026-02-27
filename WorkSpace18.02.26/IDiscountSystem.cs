using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
{
    public interface IDiscountSystem
    {
        string GetDiscountDescription();

        decimal GetDiscount(Order order);
    }
}
