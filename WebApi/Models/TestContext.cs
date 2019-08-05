using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class TestContext:DbContext
    {
        public TestContext(DbContextOptions<TestContext> options):base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
