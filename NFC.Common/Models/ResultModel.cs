﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResultModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ResultModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NFC.Common.Models
{
    /// <summary>
    /// The result model.
    /// </summary>
    public class ResultModel
    {
        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether file exists.
        /// </summary>
        public bool FileExists { get; set; }
    }
}
