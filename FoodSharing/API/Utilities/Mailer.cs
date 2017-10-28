﻿using System;
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

        public static void SendOfferAcceptanceMessage(Guid offerId, DateTime recieveTime, Guid acceptingUserId)
        {
            Offer offer = OfferRepository.Get(offerId);
            User ownerUser = UserRepository.Get(offer.OwnerId);
            User acceptingUser = UserRepository.Get(acceptingUserId);
            MailMessage mail = new MailMessage(AppAddress, new MailAddress(offer.Address));
            mail.Subject = "Twoja oferta została zaakceptowana";

            StringBuilder body = new StringBuilder();
            body.Append(string.Format("Witaj {0}!\r\n", ownerUser.Name));
            body.Append("\r\n");
            body.Append(string.Format("Twoja oferta została zaakceptowana przez użytkownika {0}.\r\n", acceptingUser.Name));
            body.Append(string.Format("Pojawi się {0}.\r\n", recieveTime));
            body.Append("Przygotuj dla niego następujące produkty:\r\n");
            foreach (Guid p in offer.ProductIds)
            {

                body.Append(string.Format("* {0},\r\n",ProductRepository.Get(p).Name));
            }
            body.Append("Pozdrawiamy\r\n FoodSharingNetwork");

            mail.Body = body.ToString();

            smtpClient.Send(mail);
        }
    }
}
