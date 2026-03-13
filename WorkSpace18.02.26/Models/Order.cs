using System.ComponentModel.DataAnnotations;
using LinqToDB.Mapping;
using WorkSpace18._02._26.Abstractions;

namespace WorkSpace18._02._26.Models
{
    public class Order
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        
        public string Number { get; set; }
        
        public DateTime Date { get; set; }
        
        [LinqToDB.Mapping.Association(
            ThisKey = "ClientId", 
            OtherKey = "Id", 
            CanBeNull = false)]
        public Client Client { get; set; }
        
        [Required] 
        public int ClientId { get; set; }

        public List<OrderItem> Items { get; set; } = new();

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

            if(DiscountSystem is not null)
                discountDiscription = DiscountSystem.GetDiscountDescription();

            return $"Заказ {Number} от {Date} для {Client} на сумму {TotalSum}.\nприменена скидка {discountDiscription} сумма со скидкой {orderSum}";
        }

        public IDiscountSystem DiscountSystem { get; set; }
    }
}
