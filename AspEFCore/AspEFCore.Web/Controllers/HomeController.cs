using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspEFCore.Web.Models;
using AspEFCore.Domain;
using AspEFCore.Data;

namespace AspEFCore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;

        public HomeController(MyContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            #region Insert
            //var province = new Province()
            //{
            //    Name = "上海",
            //    Population = 100_000_000
            //};
            //var company = new Company()
            //{
            //    Name = "王者科技有限公司",
            //    EstablishDate = new DateTime(1998, 1, 1),
            //    LegalPerson = "张大仙",
            //};
            ////开始追踪province对象
            ////_context.Provinces.Add(province);
            ////_context.Add(province);
            //_context.AddRange(province, company);
            //_context.SaveChanges();
            #endregion

            #region Select
            //var param = "北京";
            //var provinces = _context.Provinces
            //        .Where(x => x.Name == param)
            //        .ToList();
            //var provinces1 = (from p in _context.Provinces
            //                  where p.Name == param
            //                  select p).ToList();
            #endregion

            #region Update
            //var province = _context.Provinces.FirstOrDefault();
            //if (province != null)
            //{
            //    province.Population += 1000;
            //    _context.SaveChanges();
            //} 
            #endregion
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
