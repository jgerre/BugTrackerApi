namespace BugTrackerApi.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}