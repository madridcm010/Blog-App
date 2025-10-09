using back_end.models;
using Microsoft.EntityFrameworkCore;

	
namespace back_end.data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions dbcontextOptions)
			: base(dbcontextOptions)
		{
	
		}
		public DbSet<UserModel> Users { get; set; }
		public DbSet<PostModel> Posts { get; set; }
		public DbSet<CommentModel> Comments { get; set; }

	}
}
