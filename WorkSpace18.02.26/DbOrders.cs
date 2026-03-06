using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;

namespace WorkSpace18._02._26
{
    public class DbOrders : DataConnection
    {
        public DbOrders(DataOptions options) : base(options) { }
        public ITable<Product> Products => this.GetTable<Product>();
        //public ITable<Title> Title => this.GetTable< IdTitle();
        //public ITable<Article> Article => this.GetTable<Article>();
        //public ITable<Brand> Brand => this.GetTable<Brand>();
        //public ITable<Price> Price => this.GetTable<Price>();
    }
}
