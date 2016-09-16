using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using Orders.Contracts;

namespace Afterman.Interview.Problem3
{
   public class Problem3
    {
        private readonly IBus _bus;

        public Problem3(IBus bus)
        {
            _bus = bus;
        }

        public void ProcessOrder(int customerId)
        {
            _bus.Send(new PlaceOrder {CustomerId = customerId, OrderId = 2, OrderDate = DateTime.UtcNow});
        }
    }
}
