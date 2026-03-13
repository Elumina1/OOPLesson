using WorkSpace18._02._26.Abstractions;
using WorkSpace18._02._26.Models;

namespace WorkSpace18._02._26.Builders
{
    public class OrderBuilder
    {
        private Order order;
        private static int _nextOrderNumber = 1;

        public OrderBuilder()
        {
            order = new Order()
            {
                Date = DateTime.Now,
                Number = (_nextOrderNumber++).ToString(),
                Items = new List<OrderItem>()
            };
        }

        public OrderBuilder ForCustomer(Client client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }
            order.Client = client;

            return this;
        }

        public OrderBuilder WithDiscount(IDiscountSystem discountSystem)
        {
            if (discountSystem == null)
            {
                throw new ArgumentNullException(nameof(discountSystem));
            }

            order.DiscountSystem = discountSystem;

            return this;
        }

        public OrderBuilder WithPaymentKind(IPaymentService paymentService)
        {
            if (paymentService == null)
            {
                throw new ArgumentNullException(nameof(paymentService));
            }

            order.PaymentService = paymentService;

            return this;
        }

        public OrderBuilder WithItems(List<OrderItem> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            foreach (var item in items)
            {
                order.Items.Add(item);
            }

            return this;
        }

        public Order Build()
        {
            // проверка валидности заказа
            /*if (order.Client == null)
            {
                throw new InvalidOperationException("Заказ должен содержать клиента.");
            }

            if (order.Items == null || order.Items.Count == 0)
            {
                throw new InvalidOperationException("Заказ должен содержать хотя бы один элемент.");
            }

            if (order.Items.Any(i => i == null))
            {
                throw new InvalidOperationException("Список предметов пустой.");
            }*/

            return order;
        }
    }
}
