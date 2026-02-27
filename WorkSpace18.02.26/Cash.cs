using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
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
