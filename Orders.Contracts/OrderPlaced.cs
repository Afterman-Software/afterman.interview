using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Orders.Contracts
{
  public  class OrderPlaced : IEvent
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
    }
}
