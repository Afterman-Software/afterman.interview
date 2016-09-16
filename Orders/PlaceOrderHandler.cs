using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using Orders.Contracts;

namespace Orders
{
   public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
   {
       private readonly IBus _bus;
        public PlaceOrderHandler(IBus bus)
        {
            _bus = bus;
        }
        public void Handle(PlaceOrder message)
        {
            Console.WriteLine($"An order of ID {message.OrderId} has been placed for the customer with ID {message.CustomerId}.");
            _bus.Publish(new OrderPlaced {CustomerId = message.CustomerId, OrderId = message.OrderId});
        }
    }
}
