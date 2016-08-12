// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmailer.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IEmailer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NFC.Logic.Interfaces
{
    /// <summary>
    /// The Emailer interface.
    /// </summary>
    public interface IEmailer
    {
        /// <summary>
        /// The send email.
        /// </summary>
        /// <param name="csv">
        /// The csv.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string SendEmail(string csv);
    }
}
