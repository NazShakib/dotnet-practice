using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string UserType { get; set; }
    }
}
