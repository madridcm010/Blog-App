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
        public async Task<UserModel> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
