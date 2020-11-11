using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebsiteSlutuppgift.Models;

namespace WebsiteSlutuppgift.Controllers
{
    [Authorize] // User must be authenticated to get access to Homecontroller! Otherwise you will be redirected to the Loginpage.
    public class HistoriesController : Controller
    {
        private readonly ILogger<HistoriesController> logger_;

        public HistoriesController(ILogger<HistoriesController> logger)
        {
            logger_ = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
