using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repository;

namespace OA.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserPofile> userProfileRepository;

        public UserProfileService(IRepository<UserPofile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public UserPofile GetUserProfile(long id)
        {
            return userProfileRepository.get(id);
        }
    }
}
