using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model.Entities;
using API.Utilities;

namespace API.Repositories
{
    public class OrderRepository
    {
        public static IList<Order> orders = new List<Order>()
        {
        };

        public static Order Get(Guid orderId)
        {
            return orders.Where(x => x.OrderId == orderId).First();
        }

        internal static IEnumerable<Order> GetAll()
        {
            return orders;
        }

        public static bool SubmitOrder(Order order)
        {
            {
                Offer offer = OfferRepository.Get(order.OfferId);
                if (offer == null)
                    return false;

                foreach (var productId in order.ProductIds)
                    if (!offer.ProductIds.Contains(productId))
                        return false;
            }
            // all good, submit

            Mailer.SendOfferAcceptanceMessage(order);
            OfferRepository.RemoveProducts(order.OfferId, order.ProductIds);

            orders.Append(order);

            return true;
        }
    }
}
