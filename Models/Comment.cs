namespace BugTrackerApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BugId { get; set; }
        public Bug Bug { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}