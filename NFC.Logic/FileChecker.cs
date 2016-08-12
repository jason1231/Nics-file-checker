// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileChecker.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the FileChecker type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NFC.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;

    using NFC.Common.Models;
    using NFC.Common.Resources;
    using NFC.Logic.Interfaces;

    /// <summary>
    /// The file checker.
    /// </summary>
    public class FileChecker : IFileChecker
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
        /// <exception cref="Exception">
        /// </exception>
        public List<ResultModel> ProcessCsv(string csv)
        {
            if (string.IsNullOrWhiteSpace(csv))
            {
                throw new Exception(Messages.EmptyCsv);
            }

            var csvList = csv.Split(',').ToList();

            if (!csvList.Any())
            {
                throw new Exception(Messages.InvalidCsv);
            }

            var resultList = new List<ResultModel>();

            csvList.ForEach(x => resultList.Add(ProcessQueueItem(x)));

            return resultList;
        }

        /// <summary>
        /// The process queue item.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <returns>
        /// The <see cref="ResultModel"/>.
        /// </returns>
        private ResultModel ProcessQueueItem(string url)
        {
            return new ResultModel
            {
                Url = url,
                FileExists = DoesFileExist(url)
            };
        }

        /// <summary>
        /// The does file exist.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        private bool DoesFileExist(string url)
        {
            try
            {
                var request = WebRequest.Create(url) as HttpWebRequest;

                if (request != null)
                {
                    request.Method = "HEAD";
                    var response = request.GetResponse() as HttpWebResponse;

                    if (response != null)
                    {
                        response.Close();
                        return (response.StatusCode == HttpStatusCode.OK);
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
