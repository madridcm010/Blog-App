namespace back_end.models
{
    public class CommentModel
    {
        public required Guid PostID { get; set; }
        public required Guid UserID { get; set; }
        public required string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public UserModel? User { get; set; }
        public PostModel? Post { get; set; }
    }
}