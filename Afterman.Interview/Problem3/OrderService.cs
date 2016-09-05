using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

namespace Afterman.Interview.Problem3
{
    public class OrderService : IHandleMessages<PlaceOrder>, IDisposable
    {
        private static IBus orderBus;

        public OrderService()
        {
            if(orderBus == null)
                orderBus = InitOrderBus();
        }

        private IBus InitOrderBus()
        {
            var busConfig = new BusConfiguration();
            busConfig.EndpointName("Afterman.Interview.OrderService");
            busConfig.UseSerialization<JsonSerializer>();
            busConfig.EnableInstallers();
            busConfig.UsePersistence<InMemoryPersistence>();
            return Bus.Create(busConfig).Start();
        }

        static ILog log = LogManager.GetLogger<OrderService>();

        public void Handle(PlaceOrder message)
        {
            log.Info(String.Format("Order for Product: {0} placed with id: {1}",message.Product,message.Id));
            log.Info(String.Format("Publishing: OrderPlaced for Order Id: {0}", message.Id));

            var orderPlaced = new OrderPlaced
            {
                OrderId = message.Id
            };
            orderBus.Publish(orderPlaced);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (orderBus != null)
                    {
                        orderBus.Dispose();
                        disposed = true;
                    }
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    
    }
}
