using WorkSpace18._02._26.Abstractions;
using WorkSpace18._02._26.Models;

namespace WorkSpace18._02._26.Services
{
    /// <summary>
    /// система быстрых платежей
    /// </summary>
    public class FSP : IPaymentService
    {
        public string GetPaymentDiscription()
        {
            return "система быстрых платежей";
        }

        public bool Pay(Client client, double sum)
        {
            return client.Balance >= sum;
        }
    }
}
