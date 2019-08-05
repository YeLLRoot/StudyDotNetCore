using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Data;
using CoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Services
{
    public class UserService : IUserService
    {
        private readonly List<UserInfo> _userInfos = new List<UserInfo>();
        DataContext _context;
        public UserService(DataContext context)
        {
            this._context = context;
            _userInfos.Add(new UserInfo
            {
                id = 1,
                name = "鲁班",
                age = 18,
                sex = "男"
            });
            _userInfos.Add(new UserInfo
            {
                id = 2,
                name = "妲己",
                age = 19,
                sex = "女"
            });
        }
        public Task AddAsync(UserInfo model)
        {
            var MaxId = _userInfos.Count;
            model.id = MaxId + 1;
            //_context.UserInfo.Add(model);
            _userInfos.Add(model);
            //_context.SaveChangesAsync();
            return Task.CompletedTask;
            
        }

        public Task<bool> DelAsync(UserInfo model)
        {
            var user = _userInfos.Where(x=>x.id==model.id).FirstOrDefault();
            return Task.Run(()=> _userInfos.Remove(user));
        }

        public  Task<IEnumerable<UserInfo>> GetAllAsync()
        {
            return Task.Run(() => (IEnumerable<UserInfo>)_userInfos);
        }

        public Task<UserInfo> GetByIdAsync(int id)
        {
            return Task.Run(() => _userInfos.FirstOrDefault(x=>x.id==id));
        }
    }
}
