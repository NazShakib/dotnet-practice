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

        public UserPofile getProfile(long id)
        {
            return userProfileRepository.get(id);
        }

        public List<UserPofile> GetUserProfile(Expression<Func<UserPofile, bool>> filter)
        {
           return userProfileRepository.GetListByFilter(filter); 
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
