using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OA.Services;
using OA.Web.Models;
using OA.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

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

        [HttpGet]
        public ActionResult Uindex(int userId)
        {
            ViewBag.id = userId;
            List<UserViewModel> model = new List<UserViewModel>();

            this.userProfileService.GetUserProfile(i=>i.UserID==userId).ToList().ForEach(u =>
               {
                   var user = userServices.getUser(u.UserID);

                   UserViewModel userModel = new UserViewModel { 
                        ID = u.ID,
                        CreatedAt = u.CreatedTime,
                        HealthRating = u.HealthRating,
                        Comment = u.Comment,
                        UID = user.ID
                   };
                   model.Add(userModel);
               });
            return View(model);
        }


        [HttpGet]
        public ActionResult register()
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
                    return RedirectToAction("UIndex","User",new { userId = userEntity.ID });
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
            return View(model);
        }

        [HttpGet]
        public ActionResult login()
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
                    Console.WriteLine("Login Sucessfull as User");
                    const string email = "Email";
                    const string Id = "ID";
                    HttpContext.Session.SetString(email, user.Email);
                    HttpContext.Session.SetInt32(Id, user.ID);
                    ViewBag.email = email;
                    ViewBag.Id = Id;
                    
                    return RedirectToAction("Uindex","User", new { userId = user.ID });
                }
                else
                {
                    const string email = "Email";
                    const string Id = "ID";
                    HttpContext.Session.SetString(email, admin.Email);
                    HttpContext.Session.SetInt32(Id, admin.ID);
                    Console.WriteLine("Login Sucessfull as Admin");
                    return RedirectToAction("admin", "User", new { userId = admin.ID });
                }

            }
            return View(model);
        }

        [HttpGet]
        public ActionResult AddHealth(int id)
        {
            UserViewModel model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddHealth(int id, UserViewModel model)
        {
            Console.WriteLine(id);
            UserPofile pofile = new UserPofile {
                UserID = id,
                HealthRating = model.HealthRating,
                CreatedTime = DateTime.UtcNow,
                Comment = model.Comment
            };
            try
            {
                userProfileService.InsertUser(pofile);
                if (pofile.ID > 0)
                {
                    return RedirectToAction("Uindex","User", new { userId = pofile.UserID });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult editHealth(int? id)
        {
            EditHealthModel editHealth = new EditHealthModel();
            if (id.HasValue && id!=0)
            {
                UserPofile health = userProfileService.getProfile(id.Value);
                editHealth.HealthRating = health.HealthRating;
                editHealth.Comment = health.Comment;
            }
            return View(editHealth);
        }

        [HttpPost]
        public ActionResult editHealth(EditHealthModel editHealth)
        {
            UserPofile health = userProfileService.getProfile(editHealth.ID);
            health.HealthRating = editHealth.HealthRating;
            health.Comment = editHealth.Comment;
            try
            {
                userProfileService.UpdateUser(health);
                if (health.ID > 0)
                {
                    return RedirectToAction("Uindex", "User", new { userId = health.UserID });
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
            return View(editHealth);
        }

        [HttpGet]
        public ActionResult deleteHealth(int? id)
        {
            DeleteViewModel delete = new DeleteViewModel();
            if (id.HasValue && id!=0)
            {
                UserPofile deleteHealth = userProfileService.getProfile(id.Value);
                delete.ID = deleteHealth.ID;
            }
            return View(delete);
        }

        [HttpPost]
        public ActionResult deleteHealth(int? id, DeleteViewModel delete)
        {
            if (id.HasValue && id != 0)
            {
                UserPofile deleteHealth = userProfileService.getProfile(id.Value);
                delete.ID = deleteHealth.ID;
                delete.UID = deleteHealth.UserID;
                userProfileService.DeleteUser(delete.ID);
            }
            return RedirectToAction("Uindex", "User", new { userId = delete.UID });
        }


        [HttpGet]
        public ActionResult admin(int id)
        {
            List<AdminViewModel> admin = new List<AdminViewModel>();
            this.userServices.GetUserProfile(i=> i.UserType=="User").ToList().ForEach(u =>
            {
                AdminViewModel model = new AdminViewModel
                {
                    ID = u.ID,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email
                };
                admin.Add(model);
            });
            return View(admin);
        }

        public ActionResult logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("login", "User");
        }

    }
}
