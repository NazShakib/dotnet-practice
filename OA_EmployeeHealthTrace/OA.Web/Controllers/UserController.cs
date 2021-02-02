using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OA.Services;
using OA.Web.Models;
using OA.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        //[Route("User/{userId:int}")]
        public IActionResult Index(int userId)
        {

            Console.WriteLine(userId);

            List<UserViewModel> model = new List<UserViewModel>();

            this.userProfileService.GetUserProfile(userId).ToList().ForEach(u =>
               {
                   var user = userServices.getUser(u.UserID);

                   UserViewModel userModel = new UserViewModel { 
                        ID = u.ID,
                        CreatedAt = u.CreatedTime,
                        HealthRating = u.HealthRating,
                        UID = user.ID
                   };

                   model.Add(userModel);
               });
            return View(model);
        }


        [HttpGet]
        public IActionResult register()
        {
           RegisterModel model = new RegisterModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult register(RegisterModel model)
        {
            User userEntity = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = model.Password,
                UserType = model.UserType
            };
            //Console.WriteLine(userEntity.Email);
            //Console.WriteLine(userEntity.UserType);
            try
            {
                userServices.InsertUser(userEntity);
                if (userEntity.ID > 0)
                {
                    return RedirectToAction("Index",new { userId = userEntity.ID });
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
            return View(model);
        }

        [HttpGet]
        public IActionResult login()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userServices.GetByFilter(i => i.Email == model.Email && i.Password == model.Password && i.UserType== "User");
                var admin = userServices.GetByFilter(i => i.Email == model.Email && i.Password == model.Password && i.UserType=="Admin");
                if (user == null && admin==null)
                {
                    Console.WriteLine("Error!!!!");
                }
                else if(user!=null && admin==null)
                {
                    Console.WriteLine(model.Email);
                    Console.WriteLine("Login Sucessfull as User");
                    //return RedirectToAction("Index", "Home");
                }
                else
                {
                    Console.WriteLine(model.Email);
                    Console.WriteLine("Login Sucessfull as Admin");
                }

            }
            return View(model);
        }

        public IActionResult AddHealth(int id)
        {
            return View();
        }


    }
}
