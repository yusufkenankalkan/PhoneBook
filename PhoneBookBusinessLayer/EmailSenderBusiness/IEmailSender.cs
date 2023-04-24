﻿namespace PhoneBookBusinessLayer.EmailSenderBusiness
{
    public interface IEmailSender
    {
        bool SendEmail(EmailMessage message);
        Task SendEmailAsync(EmailMessage message);
    }
}
