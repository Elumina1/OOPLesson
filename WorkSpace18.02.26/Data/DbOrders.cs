using LinqToDB;
using LinqToDB.Data;
using WorkSpace18._02._26.Models;

namespace WorkSpace18._02._26.Data
{
    public class DbOrders : DataConnection
    {
        public DbOrders(DataOptions options) : base(options) { }
        public ITable<Product> Products => this.GetTable<Product>();
        public ITable<OrderItem> OrderItems => this.GetTable<OrderItem>();
        public ITable<Client> Clients => this.GetTable<Client>();
        public ITable<Order> Orders => this.GetTable<Order>();
    }
}
