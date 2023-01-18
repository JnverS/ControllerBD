using ControllerBD.Interfaces;
using ControllerBD.Models;
using Microsoft.EntityFrameworkCore;

namespace ControllerBD.Repository
{
    public class UsersRepository : IUser
    {
        private readonly ApplicationContext _appContext;

        public UsersRepository(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<User> AllUsers => _appContext.Users.ToList();

        public User getObjUser(int userid)
        {
            foreach (var user in _appContext.Users)
            {
                if (user.Id == userid)
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(User user) => _appContext.Users.Add(user);
    }
}
