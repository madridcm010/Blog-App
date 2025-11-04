using back_end.data;
using back_end.models;
using back_end.controllers;
using back_end.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace back_end.repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<UserModel> CreateUser(UserModel user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<UserModel> GetUserById(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<UserModel> GetByUsernameAsync(string Username)
        {
          return await _context.Users.FirstOrDefaultAsync(u=>u.Username = Username);
        }

        public async Task UpdateEmailAsync(UserModel user, string newEmail)
        {
          user.Email = newEmail;
          await _context.SaveChangesAsync();
        }
    }
}
