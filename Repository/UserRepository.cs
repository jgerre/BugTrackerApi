using BugTrackerApi.Data;
using BugTrackerApi.Interfaces;
using BugTrackerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BugTrackerContext _context;

        public UserRepository(BugTrackerContext context){
            _context = context;
        }
        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(p => p.Id).ToList();
        }
    }
}
