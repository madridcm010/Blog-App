internal class CommentModel
{
    public required string PostID { get; set; }
    public required string UserID { get; set; }
    public required string Content { get; set; }
    public DateTime? CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
}