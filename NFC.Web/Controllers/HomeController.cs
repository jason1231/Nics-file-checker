// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="">
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NFC.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using NFC.Common.Models;
    using NFC.Factory;
    using NFC.Factory.Interfaces;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Gets or sets the logic factory.
        /// </summary>
        private ILogicFactory LogicFactory;

        public HomeController(ILogicFactory logicFactory = null)
        {
            this.LogicFactory = logicFactory ?? new LogicFactory();
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpGet]
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// The run.
        /// </summary>
        /// <param name="csv">
        /// The csv.
        /// </param>
        /// <returns>
        /// The <see cref="JsonResult"/>.
        /// </returns>
        [HttpPost]
        public JsonResult Run(string csv)
        {
            var results = new List<ResultModel>();
            var messages = new List<string>();

            try
            {
                results = this.LogicFactory.FileChecker.ProcessCsv(csv);
            }
            catch (Exception ex)
            {
                messages.Add(ex.Message);
            }

            var successfulResults = results.Where(x => x.FileExists).ToList();

            if (successfulResults.Any())
            {
                successfulResults.ForEach(x => messages.Add(this.LogicFactory.Emailer.SendEmail(x.Url)));
            }

            return this.Json(new ResultsModel { Results = results, Messages = messages });
        }
    }
}