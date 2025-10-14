using System.ComponentModel.DataAnnotations;

namespace back_end.models
{
    public class PostModel
    {
        [Key]
        public required Guid PostID { get; set; }
        public required Guid UserID { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public UserModel? User { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
    }
}