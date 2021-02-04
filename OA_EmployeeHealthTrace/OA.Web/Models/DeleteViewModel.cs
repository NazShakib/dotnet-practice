using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Web.Models
{
    public class DeleteViewModel
    {
        public int ID { get; set; }
        [HiddenInput]
        public int UID { get; set; }
    }
}
