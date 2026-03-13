using System.ComponentModel.DataAnnotations;
using LinqToDB.Mapping;

namespace WorkSpace18._02._26.Models
{
    public class OrderItem
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }
        
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
        private Product _product;

        [LinqToDB.Mapping.Association(
            ThisKey = "ProductId", 
            OtherKey = "Id", 
            CanBeNull = false)]
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
        
        [Required] 
        public int ProductId { get; set; }

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

        public override string ToString()
        {
            return $"Amount: {Amount} Sum: {Sum}; \nProduct (Link): {Product}";
        }
    }
}
