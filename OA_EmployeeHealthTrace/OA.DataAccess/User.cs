using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<UserPofile> UserPofiles { get; set; }

    }
}
