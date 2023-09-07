﻿using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace DefaultIdentity.Services.Classes;

public class EmailSender : IEmailSender
{
    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        SmtpClient Client = new SmtpClient()
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential()
            {
                UserName = "profbat018@gmail.com",
                Password = "outuzccjsevuhubc"
            }
        };

        MailAddress FromeMail = new MailAddress("profbat018@gmail.com", "From");
        MailAddress ToeMail = new MailAddress(email, "To");


        MailMessage Message = new MailMessage()
        {
            From = FromeMail,
            Subject = subject,
            Body = htmlMessage,
            IsBodyHtml = true
        };

        Message.To.Add(ToeMail);

        try
        {
            await Client.SendMailAsync(Message);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}