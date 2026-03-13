using WorkSpace18._02._26.Abstractions;

namespace WorkSpace18._02._26.Models
{
    /// <summary>
    /// Оплата наличкой  
    /// </summary>
    public class Cash : IPaymentService
    {
        public string GetPaymentDiscription()
        {
            return "Я оплата наличкой";
        }

        public bool Pay(Client client, double sum)
        {
            return client.Balance >= sum;
        }
    }
}
