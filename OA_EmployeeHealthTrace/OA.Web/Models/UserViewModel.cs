using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Web.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public int ID { get; set; }

        [Display(Name ="Created At")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Health Rating is Required")]
        [Display(Name = "Health Rating")]
        public float HealthRating { get; set; }

        [Display(Name = "Comment")]
        public string Comment { get; set; }
        
        [HiddenInput]
        public int UID { get; set; }
    }
}
