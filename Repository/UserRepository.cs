using Data;
using Entity;
using Interface.IRepository;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            _context.users.Add(user);
            await _context.SaveChangesAsync();

        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.users.FindAsync(id);
        }
    }
}
