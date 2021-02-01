using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OA.Services;
using OA.Web.Models;
using OA.Data;

namespace OA.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserServices userServices;
        private IUserProfileService userProfileService;
        public UserController(IUserServices userServices, IUserProfileService userProfileService)
        {
            this.userServices = userServices;
            this.userProfileService = userProfileService;
        }
        public IActionResult Index()
        {
            List<UserViewModel> model = new List<UserViewModel>();
            this.userServices.GetUsers().ToList().ForEach(u =>
            {
                UserPofile userProfile = userProfileService.GetUserProfile(u.ID);

                UserViewModel user = new UserViewModel
                {
                    ID = u.ID,
                    Name = $"{userProfile.FirstName} {userProfile.LastName}",
                    HealthRating = userProfile.HealthRating
                };
                model.Add(user);
            });

            return View(model);
        }
    }
}
