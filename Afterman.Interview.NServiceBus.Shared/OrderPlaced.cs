using System;
using NServiceBus;

namespace Afterman.Interview.NServiceBus.Shared
{
    public class OrderPlaced : IEvent
    {
        public Guid OrderId { get; set; }
    }
}
