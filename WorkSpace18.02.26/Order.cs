using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSpace18._02._26
{
    class Order
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; }

        //public decimal TotalSum { get; set; }
        private decimal _totalSum;

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
        public Payment Payment { get; set; }
        public override string ToString()
        {
            return $"Заказ {Number} от {Date} для {Client.Name} на сумму {TotalSum}";
        }
    }
}
