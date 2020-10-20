using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lektion1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lektion1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
     
    }
}
