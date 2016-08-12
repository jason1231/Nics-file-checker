// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileChecker.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IFileChecker type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NFC.Logic.Interfaces
{
    using System.Collections.Generic;

    using NFC.Common.Models;

    /// <summary>
    /// The FileChecker interface.
    /// </summary>
    public interface IFileChecker
    {
        /// <summary>
        /// The process csv.
        /// </summary>
        /// <param name="csv">
        /// The csv.
        /// </param>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        List<ResultModel> ProcessCsv(string csv);
    }
}
