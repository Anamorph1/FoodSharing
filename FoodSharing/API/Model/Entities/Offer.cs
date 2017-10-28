﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class Offer
    {
        public Guid OfferId { get; set; }
        public List<Product> Products { get; set; }
        public User Owner { get; set; }
        public string Address { get; set; }
        public List<TimeFrame> RecieveTimes { get; set; }
        public bool IsForFoundationOnly { get; set; }
        //public User AcceptingUser { get; set; }
    }
}