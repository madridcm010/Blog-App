internal class PostModel
{
    public required string PostID { get; set; }
    public required string UserID { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}