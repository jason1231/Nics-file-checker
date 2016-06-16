using System.Net.Mail;
using NFC.Common.Settings;

namespace NFC.Logic
{
    public class Emailer
    {
        public void SendEmail(string message)
        {
            var mail = new MailMessage(MailSettings.To, MailSettings.From)
            {
                Subject = MailSettings.Subject,
                Body = message
            };

            var client = new SmtpClient()
            {
                Port = MailSettings.Port,
                DeliveryMethod = MailSettings.DeliveryMethod,
                UseDefaultCredentials = MailSettings.UseDefaultCredeintials,
                Host = MailSettings.Host
            };

            //client.Send(mail);
        }
    }
}
