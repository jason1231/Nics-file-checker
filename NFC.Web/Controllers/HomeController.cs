using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NFC.Common.Models;
using NFC.Common.Resources;
using NFC.Logic;

namespace NFC.Web.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public JsonResult Run(string csv)
        {
            var fileChecker = new FileChecker();
            var results = new List<ResultModel>();
            var messages = new List<string>();

            try
            {
                results = fileChecker.ProcessCsv(csv);
            }
            catch (Exception ex)
            {
                messages.Add(ex.Message);
            }

            return Json(new ResultsModel
            {
                Results = results,
                Messages = messages
            });
        }
    }
}