using BugTrackerApi.Models;

namespace BugTrackerApi.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
 
    }
}
