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
                OfferId = Guid.NewGuid(),
                OwnerId = Guid.NewGuid(),
                RecieveTimes = new List<TimeFrame>
                {
                    new TimeFrame(DateTime.Now.AddHours(11), DateTime.Now.AddHours(12)),
                    new TimeFrame(DateTime.Now.AddHours(23), DateTime.Now.AddHours(24))
                },
                ProductIds = new List<Guid>
                {
                    ProductRepository.Get("Frytki")
                },
                CreationDate = DateTime.Now.AddHours(-1)
            },
            new Offer()
            {
                OfferId = Guid.NewGuid(),
                OwnerId = Guid.NewGuid(),
                ProductIds = new List<Guid>
                {
                    ProductRepository.Get("Kurczak")
                },
                RecieveTimes = new List<TimeFrame>
                {
                    new TimeFrame(DateTime.Now.AddHours(1), DateTime.Now.AddHours(2)),
                    new TimeFrame(DateTime.Now.AddHours(3), DateTime.Now.AddHours(4))
                },
                CreationDate = DateTime.Now.AddHours(-2)
            }
        };

        public static IList<Offer> GetAll()
        {
            return offers.OrderByDescending(o => o.CreationDate).ToArray();
        }

        public static IList<Offer> GetN(int n)
        {
            return offers.OrderByDescending(o => o.CreationDate).Take(n).ToArray();
        }

        public static Offer Get(Guid offerId)
        {
            return offers.First(o => o.OfferId == offerId);
        }

        public static void Create(Offer offer)
        {
            offers.Add(offer);
        }
    }


}
