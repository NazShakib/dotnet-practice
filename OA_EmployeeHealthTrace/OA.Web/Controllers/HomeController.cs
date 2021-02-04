using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OA.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using OA.Services;
using OA.Data;

namespace OA.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserServices userServices;
        private IUserProfileService userProfileService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public ActionResult Index()
        {
            
            return View();
        }


        public ActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
