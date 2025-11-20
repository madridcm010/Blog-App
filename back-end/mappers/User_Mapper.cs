using back_end.dtos.User;
using back_end.models;
using Microsoft.AspNetCore.Identity;

namespace back_end.mappers
{
    public static class User_Mapper
    {
        public static UserModel ToUserFromCreateDto(this User_Create_Dto user_Create_Dto)
        {
            var passwordhasher = new PasswordHasher<UserModel>();
            var user = new UserModel
            {
                Username = user_Create_Dto.Username,
                Email = user_Create_Dto.Email,

            };
            user.PasswordHash = passwordhasher.HashPassword(user, user_Create_Dto.Password);
            return user;
            
               

           
        }
        
        public static object ToSafeDto(this UserModel user)
    {
        return new
        {
            user.UserID,
            user.Username,
            user.Email
        };
    }
    }
}
