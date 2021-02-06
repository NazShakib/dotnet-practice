using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Web.Models
{
    public class UserDetailsVIew
    {
        public string Name { get; set; }
        public int HealthId { get; set; }
        public DateTime CreationTime { get; set; }
        public float HealthRating { get; set; }
        public string Comment { get; set; }
    }
}
