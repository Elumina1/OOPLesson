using WorkSpace18._02._26.Models;

namespace WorkSpace18._02._26.Abstractions
{
    public interface IPaymentService
    {
        string GetPaymentDiscription();

        bool Pay(Client client, double sum);
    }
}
