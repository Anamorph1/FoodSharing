using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Dictionary<User, List<Offer>> OrderLine { get; set; }
    }
}
