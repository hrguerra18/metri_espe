using Entity;
using Interface.IRepository;
using Interface.IService;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public async Task AddAsync(User user)
        {
            await _userRepository.AddAsync(user);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await  _userRepository.GetByIdAsync(id);
        }
    }
}
