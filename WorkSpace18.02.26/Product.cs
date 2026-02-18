using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSpace18._02._26
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }
        /// <summary>
        /// Артикул
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Цена единицы товара
        /// </summary>
        public decimal Price { get; set; }
    }
}
