using API.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class OfferRepository
    {
        public static IList<Offer> offers = new List<Offer>()
        {
        };

        public static IList<Offer> GetByQueryInProds(string query)
        {
            return OfferRepository.offers
                .Where(
                o => o.Products.Any(
                    p => p.Name.Contains(query)
                ) || o.OfferDescription.Contains(query)).ToList();
        }

        public static IList<Offer> GetAll(bool isFound)
        {
            return offers.Where(o => isFound || !o.IsForFoundationOnly).OrderByDescending(o => o.CreationDate).ToArray();
        }

        public static IList<Offer> GetN(int n, bool isFound)
        {
            List<Offer> result = new List<Offer>();
            while (result.Count() < n && offers.Count() != 0)
                result.AddRange(offers);
            return result.Where(o => isFound || !o.IsForFoundationOnly).OrderByDescending(o => o.CreationDate).Take(n).ToArray();
        }

        public static Offer Get(Guid offerId)
        {
            return offers.First(o => o.OfferId == offerId);
        }

        public static bool Create(Offer offer)
        {
            if (offer.OfferDescription != null/* && offer.ProductIds.Count > 0*/ && offer.ReceiveTimes.Count > 0 && offer.Address != null)
            {
                offers.Add(offer);
                return true;
            }
            return false;
        }

        public static void RemoveProducts(Guid offerId, IEnumerable<Guid> productIds)
        {
            var offer = Get(offerId);
            if (offer == null)
                throw new Exception("Offer does not exist");
            offer.Products.RemoveAll(p => productIds.Contains(p.ProductId));

            if (offer.Products.Count() == 0)
                offers.Remove(offer);
        }
    }


}
