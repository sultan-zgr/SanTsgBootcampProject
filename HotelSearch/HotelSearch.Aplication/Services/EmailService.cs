﻿using HotelSearch.Application.Interfaces;
using HotelSearch.Application.Models;
using HotelSearch.Shared.SettingsModels;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Threading.Tasks;

namespace HotelSearch.Application.Services
{
    public class EmailService : IEmailServices
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var builder = new BodyBuilder
            {
                HtmlBody = mailRequest.Body
            };

            var email = new MimeMessage
            {
                Sender = MailboxAddress.Parse(_emailSettings.Mail),
                Subject = mailRequest.Subject,
                Body = builder.ToMessageBody()
            };
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.From.Add(MailboxAddress.Parse("HotelSearch"));
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(_emailSettings.Host, _emailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_emailSettings.Mail, _emailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }

}
