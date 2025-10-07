internal class UserModel
{
    public required string UserID { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required string Role { get; set; }
    public DateTime? CreatedAt { get; set; }


    
}