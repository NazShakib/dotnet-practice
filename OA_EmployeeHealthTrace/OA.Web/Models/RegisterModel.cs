using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Web.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User Type is required")]
        [Display(Name = "User Type")]
        public string UserType { get; set; } 

        [Required(ErrorMessage ="Email is Required")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Valid Email is Required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        [Compare("ConfrimPassword", ErrorMessage ="Password Does't Match!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confrim Password is required.")]
        [Display(Name ="Confrim Password")]
        public string ConfrimPassword { get; set; }
    }
}
