using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Services
{
    public interface IUserProfileService
    {
        UserPofile GetUserProfile(long id);
    }
}
