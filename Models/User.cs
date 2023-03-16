using System.Data;

namespace BugTrackerApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
    public enum Role
    {
        Developer,
        Tester,
        ProjectManager
    }

}