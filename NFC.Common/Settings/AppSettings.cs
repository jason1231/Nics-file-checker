// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the AppSettings type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NFC.Common.Settings
{
    /// <summary>
    /// The app settings.
    /// </summary>
    public static class AppSettings
    {
        /// <summary>
        /// The email recipients.
        /// </summary>
        public static readonly string EmailRecipients = "EmailRecipients";

        /// <summary>
        /// The email subject.
        /// </summary>
        public static readonly string EmailSubject = "EmailSubject";

        /// <summary>
        /// The smtp port.
        /// </summary>
        public static readonly string SmtpPort = "SmtpPort";

        /// <summary>
        /// The smtp host.
        /// </summary>
        public static readonly string SmtpHost = "SmtpHost";

        /// <summary>
        /// The smtp user name.
        /// </summary>
        public static readonly string SmtpUserName = "SmtpUserName";

        /// <summary>
        /// The smtp password.
        /// </summary>
        public static readonly string SmtpPassword = "SmtpPassword";
    }
}
