using back_end.models;
namespace back_end.Interfaces

{
    public interface IPostRepository
    {
        Task<List<PostModel>> GetPosts(UserModel User);
        Task<PostModel> GetbyId(int Id);
        Task<PostModel> GetbyCreateDate(DateTime Created);
    }
}
