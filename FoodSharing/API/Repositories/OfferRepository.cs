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
                OwnerId = Guid.NewGuid(),
                OfferDecription = "OPISPOISPAOSPOAPSOAPO1",
                RecieveTimes = new List<TimeFrame>
                {
                    new TimeFrame(DateTime.Now.AddHours(11), DateTime.Now.AddHours(12)),
                    new TimeFrame(DateTime.Now.AddHours(23), DateTime.Now.AddHours(24))
                },
                ProductIds = new List<Guid>
                {
                    ProductRepository.Get("Frytki")
                },
                CreationDate = DateTime.Now.AddHours(-1),
                Address = "ADRES 123",
                IsForFoundationOnly = false
            },
            new Offer()
            {
                OwnerId = Guid.NewGuid(),
                OfferDecription = "OPISPOISPAOSPOAPSOAPO2",
                ProductIds = new List<Guid>
                {
                    ProductRepository.Get("Kurczak")
                },
                RecieveTimes = new List<TimeFrame>
                {
                    new TimeFrame(DateTime.Now.AddHours(1), DateTime.Now.AddHours(2)),
                    new TimeFrame(DateTime.Now.AddHours(3), DateTime.Now.AddHours(4))
                },
                CreationDate = DateTime.Now.AddHours(-2),
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
            if (offer.OfferDecription != null && offer.ProductIds.Count > 0 && offer.RecieveTimes.Count > 0 && offer.Address != null)
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
