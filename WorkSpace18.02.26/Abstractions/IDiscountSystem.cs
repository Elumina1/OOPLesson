using WorkSpace18._02._26.Models;

namespace WorkSpace18._02._26.Abstractions
{
    public interface IDiscountSystem
    {
        string GetDiscountDescription();

        decimal GetDiscount(Order order);
    }
}
