using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;
using OA.Repository;


namespace OA.Services
{
   public class UserService : IUserServices
    {
        private IRepository<User> UserRepository;
        private IRepository<UserPofile> UserProfileRepository;
        public UserService(IRepository<User> UserRepository,IRepository<UserPofile> UserProfileRepository)
        {
            this.UserRepository = UserRepository;
            this.UserProfileRepository = UserProfileRepository;
        }

        public void DeleteUser(long id)
        {
            UserPofile userPofile = UserProfileRepository.get(id);
            UserProfileRepository.Remove(userPofile);
            User user = UserRepository.get(id);
            UserRepository.Remove(user);
        }

        public User getUser(long id)
        {
            return UserRepository.get(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return UserRepository.GetAll();
        }

        public void InsertUser(User user)
        {
             UserRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            UserRepository.Update(user);
        }
    }
}
