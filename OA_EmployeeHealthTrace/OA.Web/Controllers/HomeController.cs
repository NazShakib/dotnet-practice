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
       
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            RegisterModel model = new RegisterModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            User userEntity = new User
            {
                Email = model.Email,
                UserType = model.UserType,
                Password = model.Password,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
                UserProfile = new UserPofile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now,
                }
            };
            userServices.InsertUser(userEntity);
            if (userEntity.ID > 0)
            {
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
