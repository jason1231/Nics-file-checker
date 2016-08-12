// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Emailer.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Emailer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NFC.Logic
{
    using System;
    using System.Net.Mail;

    using NFC.Common.Settings;
    using NFC.Logic.Interfaces;

    /// <summary>
    /// The Emailer.
    /// </summary>
    public class Emailer : IEmailer
    {
        /// <summary>
        /// Send email
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string SendEmail(string url)
        {
            using (
                var msg = new MailMessage(
                    MailSettings.From, 
                    MailSettings.To, 
                    MailSettings.Subject, 
                    $"The following url has been verified {url}"))
            {
                var client = new SmtpClient
                                 {
                                     UseDefaultCredentials = MailSettings.UseDefaultCredeintials, 
                                     Host = MailSettings.Host, 
                                     Port = MailSettings.Port, 
                                     EnableSsl = MailSettings.EnableSsl, 
                                     DeliveryMethod = MailSettings.DeliveryMethod, 
                                     Credentials = MailSettings.Credentials, 
                                     Timeout = MailSettings.Timeout
                                 };

                try
                {
                    client.Send(msg);
                    return "Mail has been successfully sent!";
                }
                catch (Exception ex)
                {
                    return $"Error sending email!: {ex.Message}";
                }
            }
        }
    }
}