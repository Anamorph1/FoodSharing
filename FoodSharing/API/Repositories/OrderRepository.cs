using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model.Entities;

namespace API.Repositories
{
    public class OrderRepository
    {
        public static IList<Order> orders = new List<Order>()
        {
            new Order
            {
                OrderId = Guid.NewGuid(),
                OwnerId = Guid.NewGuid(),
                OfferIds = new List<Guid>()
                {
                    Guid.NewGuid(),
                    Guid.NewGuid()
                }
            },
            new Order
            {
                OrderId = Guid.NewGuid(),
                OwnerId = Guid.NewGuid(),
                OfferIds = new List<Guid>()
                {
                Guid.NewGuid(),
                Guid.NewGuid()
                }
            }
        };
    }
}
