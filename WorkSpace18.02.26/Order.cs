using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace WorkSpace18._02._26
{
    public class Order
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; }

        //public decimal TotalSum { get; set; }
        private decimal _totalSum;

        public decimal GetTotalSum()
        {
            var discount = 0m;
            if (DiscountSystem != null)
            {
                discount = DiscountSystem.GetDiscount(this);
            }

            return TotalSum - discount;
        }

        public decimal TotalSum
        {
            get 
            {
                _totalSum = 0;
                foreach (var item in Items)
                {
                    _totalSum += item.Sum;
                }
                return _totalSum; 
            }
        }

        /// <summary>
        /// Способ оплаты
        /// </summary>
        public IPaymentService PaymentService { get; set; }
        public override string ToString()
        {
            var discountDiscription = "(без скидки)";
            var orderSum = GetTotalSum();
            if(DiscountSystem != null)
            {
                discountDiscription = DiscountSystem.GetDiscountDescription();
            }
            
            return $"Заказ {Number} от {Date} для {Client.Name} на сумму {TotalSum}.\n применена скидка {discountDiscription} сумма со скидкой {orderSum}";
        }

        public IDiscountSystem DiscountSystem { get; set; }

    }
}
