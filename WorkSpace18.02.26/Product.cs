using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace WorkSpace18._02._26
{
    [Table ("Product")]
    public class Product
    {
        [PrimaryKey, Identity]
        public int Id { get; set; }

        [Column, NotNull]
        public string Title { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        [Column, NotNull]
        public string Article { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        [Column, NotNull]
        public string Brand { get; set; }
        /// <summary>
        /// Цена единицы товара
        /// </summary>
        [Column, NotNull]
        public decimal Price { get; set; }
    }
}
