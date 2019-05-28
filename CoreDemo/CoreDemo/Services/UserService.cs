using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;

namespace CoreDemo.Services
{
    public class UserService : IUserService
    {
        private readonly List<UserInfo> _userInfos = new List<UserInfo>();
        public UserService()
        {
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
            var MaxId = _userInfos.Max(x=>x.id);
            model.id = MaxId + 1;
            _userInfos.Add(model);
            return Task.CompletedTask;
            //throw new NotImplementedException();
        }

        public Task<IEnumerable<UserInfo>> GetAllAsync()
        {
            return Task.Run(()=>_userInfos.AsEnumerable());
        }

        public Task<UserInfo> GetByIdAsync(int id)
        {
            return Task.Run(() => _userInfos.FirstOrDefault(x=>x.id==id));
        }
    }
}
