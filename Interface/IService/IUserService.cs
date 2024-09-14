using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.IService
{
    public interface IUserService
    {
        Task AddAsync(User user);
        Task<User> GetByIdAsync(int id);
    }
}
