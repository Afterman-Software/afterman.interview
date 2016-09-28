using Afterman.Interview.NServiceBus.Shared;
using NServiceBus;
using NServiceBus.Logging;

namespace Afterman.Interview.NServiceBus.Subscriber
{
    public class OrderCreatedHandler : IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger<OrderCreatedHandler>();

        public void Handle( OrderPlaced message )
        {
            log.Info( $"Handling: OrderPlaced for Order Id: {message.OrderId}" );
            SendEmail( "nobody@safety.netz", $"Thanks for your order\nOrderId = message.OrderId" );
        }

        public void SendEmail(string emailAddress, string message )
        {
            log.Info( $"TODO: SendEmail to {emailAddress}, message {message}" );
            // TODO
        }
    }
}
