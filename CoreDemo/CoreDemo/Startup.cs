using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Data;
using CoreDemo.Services;
using CoreDemo.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreDemo
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //var connectString = _configuration["ConnectionStrings:DefaultConnection"];
            //var connectString =_configuration.GetConnectionString("DefaultConnection");  
            services.AddDbContext<DataContext>(options=> 
            {
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddSingleton<IUserService, UserService>();
            services.Configure<ConnectionOptions>(_configuration.GetSection("ConnectionStrings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context,next) =>
            //{
            //    logger.LogInformation("M1 Start");
            //    await context.Response.WriteAsync("Hello World!");
            //    await next();//调用下一个中间件
            //    logger.LogInformation("M1 End");
            //});
            //app.Run(async (context)=>
            //{
            //    logger.LogInformation("M2 Start");
            //    await context.Response.WriteAsync("你好！");
            //    logger.LogInformation("M2 End");
            //});

            //添加错误输出中间件
            app.UseStatusCodePages();
            //添加访问静态资源中间件
            app.UseStaticFiles();
            //配置默认路由
            app.UseMvc(routes=> 
            {
                routes.MapRoute(
                    name:"default",
                    template:"{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
