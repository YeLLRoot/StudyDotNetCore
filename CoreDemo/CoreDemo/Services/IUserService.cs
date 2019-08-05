using CoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserInfo>> GetAllAsync();
        Task<UserInfo> GetByIdAsync(int id);
        Task AddAsync(UserInfo model);
        Task<bool> DelAsync(UserInfo model);
    }
}
