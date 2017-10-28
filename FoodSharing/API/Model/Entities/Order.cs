﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public IEnumerable<Guid> ProductIds { get; set; }
        public Guid OwnerId { get; set; }
        public TimeFrame ReceiveTime { get; set; }
        public Guid OfferId { get; set; }
    }
}
