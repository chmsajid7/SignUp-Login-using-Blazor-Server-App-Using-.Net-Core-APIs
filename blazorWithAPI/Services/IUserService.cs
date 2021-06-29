using blazorWithAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWithAPI.Services
{
    public interface IUserService
    {
        public Task<User> LoginAsync(User user);
        public Task<User> RegisterUserAsync(User user);
    }
}
