using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NServiceBus;
using Afterman.Interview.Problem3;

namespace Afterman.Interview.Tests.Problem3
{
    [TestClass]
    public class NSBEndpointTests
    {
        [TestMethod]
        public void PlaceMockOrder()
        {
            OrderService osb = new OrderService();
            EmailService esb = new EmailService();
            var busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("Afterman.Interview.WebService");
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.EnableInstallers();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            using (var bus = Bus.Create(busConfiguration).Start())
            {
                var id = Guid.NewGuid();
                var placeOrder = new PlaceOrder
                {
                    Product = "New shoes",
                    Id = id
                };
                bus.Send("Afterman.Interview.OrderService", placeOrder);
                Console.WriteLine(String.Format("Sent a PlaceOrder message with id: {0}", placeOrder.Id));

                // TODO: validate email sent, as validated by manual log inspection.
            }
        }
    }
}
