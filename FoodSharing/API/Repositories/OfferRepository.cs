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
            new Offer()
            {
                OwnerId = Guid.Parse("User2222-2222-2222-2222-222222222222"),
                OfferDescription = "OPISPOISPAOSPOAPSOAPO1",
                RecieveTimes = new List<string>
                {
                    "Friday evening",
                    "Saturday morning"
                },
                ProductIds = new List<Guid>
                {
                    Guid.Parse("Produ111-1111-1111-1111-111111111111")
                },
                Address = "ADRES 123",
                IsForFoundationOnly = false
            },
            new Offer()
            {
                OwnerId = Guid.Parse("User2222-2222-2222-2222-222222222222"),
                OfferDescription = "OPISPOISPAOSPOAPSOAPO2",
                ProductIds = new List<Guid>
                {
                    Guid.Parse("Produ222-2222-2222-2222-222222222222")
                },
                RecieveTimes = new List<string>
                {
                    "Wednesday, 10pm to 11pm"
                },
                Address = "ADRES 456",
                IsForFoundationOnly = false
            }
        };

        public static IList<Offer> GetByQueryInProds(string query)
        {
            return OfferRepository.offers.Where(o => o.ProductIds.Any(p => ProductRepository.Get(p).Name.Contains(query) || ProductRepository.Get(p).Description.Contains(query))).ToList();
        }

        public static IList<Offer> GetAll()
        {
            return GetN(100);
        }

        public static IList<Offer> GetN(int n)
        {
            List<Offer> result = new List<Offer>();
            while (result.Count() < 100)
                result.AddRange(offers);
            return result.OrderByDescending(o => o.CreationDate).Take(n).ToArray();
        }

        public static Offer Get(Guid offerId)
        {
            return offers.First(o => o.OfferId == offerId);
        }

        public static bool Create(Offer offer)
        {
            if (offer.OfferDescription != null && offer.ProductIds.Count > 0 && offer.RecieveTimes.Count > 0 && offer.Address != null)
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
            offer.ProductIds.RemoveAll(p => productIds.Contains(p));

            if (offer.ProductIds.Count() == 0)
                offers.Remove(offer);
        }
    }


}
