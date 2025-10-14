using back_end.models;
namespace back_end.Interfaces


{ 
    public interface IUserRepository
    {
        Task<UserModel> CreateUser(UserModel User);
        //Task<UserModel> DeleteUser(UserModel User);
        Task<UserModel> GetUserById(int id);
    }
}
