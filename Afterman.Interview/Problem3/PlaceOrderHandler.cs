using NServiceBus;

namespace Afterman.Interview.Problem3
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrderCommand>
    {
        private readonly IBus omsBus;

        public PlaceOrderHandler(IBus orderBus)
        {
            this.omsBus = orderBus;
        }

        public void Handle(PlaceOrderCommand message)
        {
            var orderPlaced = new OrderPlacedEvent
            {
                OrderId = message.OrderId,
                CustomerId = message.CustomerId,
                ProductId = message.ProductId
            };

            this.omsBus.Publish(orderPlaced);
        }
    }
}
