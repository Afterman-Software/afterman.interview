using NServiceBus;
using NServiceBus.Logging;

namespace Afterman.Interview.Problem3
{
    public class OrderCreatedHandler : IHandleMessages<OrderPlacedEvent>
    {
        static ILog log = LogManager.GetLogger<OrderCreatedHandler>();

        public void Handle(OrderPlacedEvent message)
        {
            // Send an email
            log.Info($"Sending email alert for order ID: {message.OrderId}, Product ID: {message.ProductId}, Customer ID: {message.CustomerId}");
            MockSupplyChainService.EmailSender.EmailSentEvent.Set();
        }
    }
}
