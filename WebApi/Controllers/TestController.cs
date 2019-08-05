using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestContext _context;
        public TestController(TestContext context)
        {
            _context = context;
            if (_context.Items.Count()==0)
            {
                _context.Items.Add(new Item { Name = "Karry" });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(long id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item==null)
            {
                return NotFound();
            }
            return item;
        }
        [HttpGet]
        public ActionResult<Status>  AddItem(Item item)
        {
            _context.Items.Add(item);
           var result = _context.SaveChanges();
            if (result>0)
            {
                return new Status { Code=200,Message="添加成功！" };
            }
            return new Status { Code=400,Message = "添加失败！" };
        }
    }
}