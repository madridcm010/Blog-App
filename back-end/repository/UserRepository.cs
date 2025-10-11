using back_end.data;
using back_end.models;
using back_end.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace back_end.repository
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
