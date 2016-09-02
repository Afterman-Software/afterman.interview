using NServiceBus;

namespace Afterman.Interview.Problem3
{
    public class OrderPlacedEvent : IEvent
    {
        public long OrderId { get; set; }

        public string CustomerId { get; set; }

        public string ProductId { get; set; }
    }
}
