using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
{
    public class OrderBuilder
    {
        private Order order;
        public OrderBuilder()
        {
            order = new Order()
            {
                Date = DateTime.Now,
                Number = "1",
            };

        }

        public OrderBuilder ForCustomer(Client client)
        {
            //todo проверка что пришел клиент (не пустой)
            order.Client = client;
            return this;
        }

        public OrderBuilder WithDiscount(IDiscountSystem discountSystem)
        {
            //todo
            order.DiscountSystem = discountSystem;
            return this;
        }

        public Order Build()
        {
            //todo проверить валидность всего заказа
            return order;
        }
    }
}
