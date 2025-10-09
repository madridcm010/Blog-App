

namespace back_end.models
{

    public class UserModel
    {
        public required Guid UserID { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string Role { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ICollection<PostModel>? Posts { get; set; }
        public ICollection<CommentModel>? Comments { get; set; }
    }
}