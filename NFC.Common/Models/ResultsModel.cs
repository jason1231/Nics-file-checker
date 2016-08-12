// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResultsModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ResultsModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace NFC.Common.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The results model.
    /// </summary>
    public class ResultsModel
    {
        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        public List<ResultModel> Results { get; set; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public List<string> Messages { get; set; }
    }
}
