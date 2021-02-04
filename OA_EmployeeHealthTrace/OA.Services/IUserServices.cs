using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using OA.Data;

namespace OA.Services
{
    public interface IUserServices
    {
        User GetByFilter(Expression<Func<User, bool>> filter);
        IEnumerable<User> GetUsers();
        List<User> GetUserProfile(Expression<Func<User, bool>> filter);
        User getUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}
