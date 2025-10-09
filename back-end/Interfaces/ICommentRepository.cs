using back_end.models;

namespace back_end.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<CommentModel>> GetAllComments();
        Task<CommentModel> GetbyUser(UserModel User);
        Task<CommentModel> GetByDate(DateTime? Date);
    }
}
