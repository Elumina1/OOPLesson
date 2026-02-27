namespace WorkSpace18._02._26
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
