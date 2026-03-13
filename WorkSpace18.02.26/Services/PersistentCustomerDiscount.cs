using WorkSpace18._02._26.Abstractions;
using WorkSpace18._02._26.Models;

namespace WorkSpace18._02._26.Services
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
