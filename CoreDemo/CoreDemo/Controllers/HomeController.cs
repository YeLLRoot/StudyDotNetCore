using CoreDemo.Models;
using CoreDemo.Services;
using CoreDemo.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class HomeController:Controller
    {
        private readonly IUserService _userService;

        //控制器中注入配置文件强类型类
        //private readonly IOptions<ConnectionOptions> _options;
        //public HomeController(IUserService userService,IOptions<ConnectionOptions> options)
        //{
        //    _userService = userService;
        //    _options = options;
        //}
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "用户列表";//await _userService.GetAllAsync()
            //ViewData["userList"] = await _userService.GetAllAsync();
            return View(await _userService.GetAllAsync());
        }

        public IActionResult Add()
        {
            ViewBag.Title = "添加用户";

            return View(new UserInfo());
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                await _userService.AddAsync(model);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int userid)
        {
            ViewBag.Title = "编辑用户";
            var user = await _userService.GetByIdAsync(userid);
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,UserInfo user)
        {
            if (ModelState.IsValid)
            {
                var exist = await _userService.GetByIdAsync(id);
                if (exist==null)
                {
                    return NotFound();
                }
                exist.name = user.name;
                exist.age = user.age;
                exist.sex = user.sex;
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int userid)
        {
            if (ModelState.IsValid)
            {
                var exist = await _userService.GetByIdAsync(userid);
                if (exist == null)
                {
                    return NotFound();
                }
                await _userService.DelAsync(exist);
            }
            return Redirect("Index");
        }
    }
}
