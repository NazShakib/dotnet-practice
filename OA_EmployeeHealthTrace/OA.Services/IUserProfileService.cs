using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using OA.Data;

namespace OA.Services
{
    public interface IUserProfileService
    {
        List<UserPofile> GetUserProfile(Expression<Func<UserPofile, bool>> filter);

        UserPofile getProfile(long id);

        void InsertUser(UserPofile profile);
        void UpdateUser(UserPofile profile);
        void DeleteUser(long id);
    }
}
