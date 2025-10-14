

using System.ComponentModel.DataAnnotations;

namespace back_end.models
{

    public class UserModel
    {
        [Key]
        public Guid? UserID { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public  string? PasswordHash { get; set; }
        public  string? Role { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ICollection<PostModel>? Posts { get; set; }
        public ICollection<CommentModel>? Comments { get; set; }
    }
}