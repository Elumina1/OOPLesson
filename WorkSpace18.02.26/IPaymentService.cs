using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace18._02._26
{
    public interface IPaymentService
    {

        string GetPaymentDiscription();

        bool Pay(Client client, double sum);
        

    }
}
