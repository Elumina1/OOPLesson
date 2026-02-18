using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSpace18._02._26
{
    public class OrderItem
    {

        /// <summary>
        /// Количество товара
        /// </summary>
        //public int Amount { get; set; }
        private int _amount;

        public int Amount
        {
            get 
            { 
                return _amount; 
            }
            set 
            { 
                _amount = value;
                UpdateSum();
            }
        }


        /// <summary>
        /// Товар
        /// </summary>
        //public Product Product { get; set; }
        private Product _product;

        public Product Product
        {
            get 
            { 
                return _product; 
            }
            set 
            { 
                _product = value;
                UpdateSum();
            }
        }

        /// <summary>
        /// Общая сумма
        /// </summary>
        public decimal Sum { get; set; }

        public void UpdateSum()
        {
            if (Product == null)
            {
                return;
            }
            
            Sum = Amount * Product.Price;
        }
    }
}
