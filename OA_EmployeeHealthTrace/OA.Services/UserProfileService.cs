using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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


        public void DeleteUser(long id)
        {
            UserPofile profile = userProfileRepository.get(id);
            userProfileRepository.Remove(profile);
        }

        public List<UserPofile> GetUserProfile(long id)
        {
           return userProfileRepository.GetListByFilter(id); 
        }

        public void InsertUser(UserPofile profile)
        {
            userProfileRepository.Insert(profile);
        }

        public void UpdateUser(UserPofile profile)
        {
            userProfileRepository.Update(profile);
        }
    }
}
