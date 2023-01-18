using ControllerBD.Models;

namespace ControllerBD.Interfaces
{
    public interface IUser
    {
        IEnumerable<User> AllUsers { get; }

        User getObjUser(int userid);
    }
}
