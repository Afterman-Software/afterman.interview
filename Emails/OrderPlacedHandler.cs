using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using Orders.Contracts;

namespace Emails
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        public void Handle(OrderPlaced message)
        {
            Console.WriteLine($"Email Notification sent for customer with ID {message.CustomerId} for order with ID {message.OrderId}");
        }
    }
}
