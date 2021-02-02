using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
   public class UserPofile : BaseEntity
    {
        public int UserID { get; set; }
        public float HealthRating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedTime { get; set; }
        public virtual User User { get; set; }
    }
}
