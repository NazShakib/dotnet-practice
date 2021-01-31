using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Services
{
    public interface IUserServices
    {
        IEnumerable<User> GetUsers();
        User getUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}
