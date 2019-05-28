using CoreDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class UserCountViewComponent:ViewComponent
    {
        private readonly IUserService _userService;
        public UserCountViewComponent(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int userid)
        {
            var user = await _userService.GetByIdAsync(userid);
            
            return View(user);
        }
    }
}
