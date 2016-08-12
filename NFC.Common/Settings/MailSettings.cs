namespace NFC.Common.Settings
{
    using System.Configuration;
    using System.Net;
    using System.Net.Mail;

    public static class MailSettings
    {
        public static string To = ConfigurationManager.AppSettings[AppSettings.EmailRecipients];
        public static string From = ConfigurationManager.AppSettings[AppSettings.SmtpUserName];
        public static string Subject = ConfigurationManager.AppSettings[AppSettings.EmailSubject];
        public static int Port => 587;
        public static SmtpDeliveryMethod DeliveryMethod => SmtpDeliveryMethod.Network;
        public static bool UseDefaultCredeintials => true;
        public static bool EnableSsl => true;
        public static string Host => "smtp.gmail.com";
        public static int Timeout => 20000;
        public static NetworkCredential Credentials => new NetworkCredential(
            ConfigurationManager.AppSettings[AppSettings.SmtpUserName], 
            ConfigurationManager.AppSettings[AppSettings.SmtpPassword]);
    }
}
