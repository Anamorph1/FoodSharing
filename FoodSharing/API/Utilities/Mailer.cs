using System;
using System.Collections.Generic;
using System.Linq;
using API.Model.Entities;
using System.Net.Mail;
using System.Net;
using System.Text;
using API.Repositories;

namespace API.Utilities
{
    public class Mailer
    {
        private static readonly MailAddress AppAddress = new MailAddress("foodsharingnetwork@gmail.com", "Food Sharing Network");

        private static readonly string AppPassword = "zaq1@WSX";

        private static readonly SmtpClient smtpClient = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(AppAddress.Address, AppPassword)
        };

        public static bool SendOfferAcceptanceMessage(Order order)
        {
            Offer offer = OfferRepository.Get(order.OfferId);
            User ownerUser = UserRepository.Get(offer.OwnerId);
            User acceptingUser = UserRepository.Get(order.OwnerId);
            MailMessage mail = new MailMessage(AppAddress, new MailAddress(acceptingUser.Email));
            mail.Subject = "Your offer was accepted!";

            StringBuilder body = new StringBuilder();
            body.Append(string.Format("Hi {0}!\r\n", ownerUser.Name));
            body.Append("\r\n");
            body.Append(string.Format("Your offer \"{0}\" was accepted by {1}.\r\n", offer.OfferDescription ,acceptingUser.Name));
            body.Append(string.Format("He will meet with you {0}.\r\n", order.ReceiveTime));
            body.Append("Please prepare following products for him to pick up:\r\n");
            foreach (Guid p in order.ProductIds)
            {

                body.Append(string.Format("* {0},\r\n",ProductRepository.Get(p).Name));
            }
            body.Append("Have a great day!\r\n FoodSharingNetwork");

            mail.Body = body.ToString();

            try
            {
                smtpClient.Send(mail);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
