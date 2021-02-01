﻿using Microsoft.AspNetCore.Mvc;
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

        public string Name { get; set; }

        [Display(Name = "Health Rating")]
        public float HealthRating { get; set; }
        [Display(Name = "Created AT")]
        public DateTime CreatedTime { get; set; }
    }
}