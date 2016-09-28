using System;
using NServiceBus;

namespace Afterman.Interview.NServiceBus.Shared
{
    public class PlaceOrder : ICommand
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
    }
}
