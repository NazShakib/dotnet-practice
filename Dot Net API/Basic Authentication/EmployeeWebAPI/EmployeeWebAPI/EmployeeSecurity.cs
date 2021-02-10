using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDataAccess;

namespace EmployeeWebAPI
{
    public class EmployeeSecurity
    {
        public static bool login(string username, string password)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Users.Any(user => user.Username.ToUpper() == username.ToUpper() 
                && user.Password == password);
            }
        }
    }
}