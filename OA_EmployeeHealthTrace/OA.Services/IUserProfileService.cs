using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Services
{
    public interface IUserProfileService
    {
        List<UserPofile> GetUserProfile(long id);
    }
}
