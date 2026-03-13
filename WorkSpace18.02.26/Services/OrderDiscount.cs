using WorkSpace18._02._26.Abstractions;
using WorkSpace18._02._26.Models;

namespace WorkSpace18._02._26.Services
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
