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

        [Display(Name = "Health ID")]
        public int ID { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Health Rating")]
        public float HealthRating { get; set; }

        [Display(Name = "User ID")]
        public int UID { get; set; }
    }
}
