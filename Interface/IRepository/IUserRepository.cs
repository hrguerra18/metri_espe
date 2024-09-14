using Entity;

namespace Interface.IRepository
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task<User> GetByIdAsync(int id);
    }
}
