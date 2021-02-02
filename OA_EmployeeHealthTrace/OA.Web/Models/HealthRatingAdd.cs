using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace OA.Web.Models
{
    public class HealthRatingAdd
    {
        [HiddenInput]
        public int UID { get; set; }

        [HiddenInput]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Health Rating is Required")]
        [Display(Name = "Health Rating")]
        public float HealthRating { get; set; }

        [Display(Name = "Comment")]
        public string Comment { get; set; }
    }
}
