internal class UserModel
{
    public required string UserID { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public required bool IsAdmin { get; set; }
    
}