using System.Configuration;
using System.Net.Mail;

namespace NFC.Common.Settings
{
    public static class MailSettings
    {
        public static string To = ConfigurationManager.AppSettings[AppSettings.EmailRecipients];
        public static string From = ConfigurationManager.AppSettings[AppSettings.EmailSender];
        public static string Subject = ConfigurationManager.AppSettings[AppSettings.EmailSubject];
        public static int Port => 25;
        public static SmtpDeliveryMethod DeliveryMethod => SmtpDeliveryMethod.Network;
        public static bool UseDefaultCredeintials => true;
        public static string Host => "smtp.google.com";
    }
}
