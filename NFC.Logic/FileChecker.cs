using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using NFC.Common.Models;
using NFC.Common.Resources;

namespace NFC.Logic
{
    public class FileChecker
    {
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

        private ResultModel ProcessQueueItem(string url)
        {
            return new ResultModel
            {
                Url = url,
                FileExists = DoesFileExist(url)
            };
        }

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
