﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Afterman.Interview.Problem3
{
    public class PlaceOrder :
        ICommand
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
    }
}
