using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
   public class UserPofile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float HealthRating { get; set; }

        public virtual User User { get; set; }
    }
}
