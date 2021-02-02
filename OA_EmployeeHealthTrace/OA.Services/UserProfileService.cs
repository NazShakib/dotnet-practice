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

        public List<UserPofile> GetUserProfile(long id)
        {
            return userProfileRepository.GetListByFilter(id);
        }
    }
}
