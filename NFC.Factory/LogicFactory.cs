// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogicFactory.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the LogicFactory type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NFC.Factory
{
    using NFC.Factory.Interfaces;
    using NFC.Logic.Interfaces;

    /// <summary>
    /// The logic factory.
    /// </summary>
    public class LogicFactory : ILogicFactory
    {
        /// <summary>
        /// Gets or sets the emailer.
        /// </summary>
        public IEmailer Emailer { get; set; }

        /// <summary>
        /// Gets or sets the file checker.
        /// </summary>
        public IFileChecker FileChecker { get; set; }
    }
}
 