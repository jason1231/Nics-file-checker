// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILogicFactory.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ILogicFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NFC.Factory.Interfaces
{
    using NFC.Logic.Interfaces;

    /// <summary>
    /// The LogicFactory interface.
    /// </summary>
    public interface ILogicFactory
    {
        /// <summary>
        /// Gets or sets the emailer.
        /// </summary>
        IEmailer Emailer { get; set; }

        /// <summary>
        /// Gets or sets the file checker.
        /// </summary>
        IFileChecker FileChecker { get; set; }
    }
}
